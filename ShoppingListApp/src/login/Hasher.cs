using Konscious.Security.Cryptography;
using System.Security.Cryptography;
using System.Text;

namespace ShoppingListApp.src.Login
{
    public static class Hasher
    {
        private const int SALT_SIZE_BYTES = 32;
        private const int HASH_SIZE_BYTES = 32;
        
        private const int MEMORY_TO_USE_KB = 1024 * 64; // 64mb
        private const int NO_OF_ITERATIONS = 4; // lowest amount of iterations recommended
        private const int DEGREE_OF_PARALLELISM = 8;

        /// <summary>
        /// Generates a random 32-byte salt for enhanced security.
        /// </summary>
        /// <returns>32-byte array containing the salt.</returns>
        private static byte[] GenerateSalt()
        {
            byte[] salt = new byte[SALT_SIZE_BYTES];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            return salt;
        }

        /// <summary>
        /// Salts and hashes a password to ensure it isn't stored in plain text.
        /// </summary>
        /// <param name="s">The string to be hashed.</param>
        /// <returns>32-byte array containing the salted and hashed password.</returns>
        private static byte[] HashAndSaltText(string s, byte[] salt)
        {
            byte[] hashedPassword = new Argon2id(Encoding.UTF8.GetBytes(s))
            {
                Salt = salt,
                DegreeOfParallelism = DEGREE_OF_PARALLELISM, // use half of available cores
                MemorySize = MEMORY_TO_USE_KB,
                Iterations = NO_OF_ITERATIONS
            }.GetBytes(HASH_SIZE_BYTES);

            return hashedPassword;
        }

        /// <summary>
        /// A salt needs to be stored alongside the hashed text, and so this function combines
        /// the salt and hashed password into a single array.
        /// </summary>
        /// <param name="s">The string to be hashed.</param>
        /// <returns>64-byte array containing the salt (32 bytes) + hashed text (32 bytes).</returns>
        public static byte[] Hash(string s)
        {
            byte[] salt = GenerateSalt();
            byte[] szHashedPass = HashAndSaltText(s, salt);

            byte[] combined = new byte[SALT_SIZE_BYTES + HASH_SIZE_BYTES];

            Buffer.BlockCopy(salt, 0, combined, 0, salt.Length); //copy salt to first 32 bytes of "combined"
            Buffer.BlockCopy(szHashedPass, 0, combined, salt.Length, szHashedPass.Length); // copy hashed+salted password to last 32 bytes of "combined"

            return combined;
        }

        /// <summary>
        /// Compare the hashed password to given text.
        /// </summary>
        /// <param name="text">The text the hashed byte array is to be checked against.</param>
        /// <param name="saltHash">The salted+hashed byte array the text is to be checked against.</param>
        /// <returns>TRUE if success, FALSE if failed.</returns>
        public static bool VerifyHash(string text, byte[] saltHash)
        {
            byte[] salt = new byte[SALT_SIZE_BYTES];
            byte[] pass = new byte[SALT_SIZE_BYTES]; 

            Buffer.BlockCopy(saltHash, 0, salt, 0, salt.Length);
            Buffer.BlockCopy(saltHash, salt.Length, pass, 0, pass.Length);

            return VerifyHash(text, salt, pass);
        }

        /// <summary>
        /// Compare the hashed password to given text.
        /// </summary>
        /// <param name="text">The text the hashed byte array is to be checked against.</param>
        /// <param name="salt">The salt (first 32 bytes of salt+hash combination) of the hash.</param>
        /// <param name="hash">The hash (last 32 bytes of salt+hash combination) that the text will be checked against.</param>
        /// <returns>TRUE if success, FALSE if failed.</returns>
        public static bool VerifyHash(string text, byte[] salt, byte[] hash)
        {
            return HashAndSaltText(text, salt).SequenceEqual(hash);
        }
    }
}
