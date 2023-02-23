using Konscious.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListApp
{
    public static class Hasher
    {
        public static byte[] GenerateSalt()
        {
            byte[] salt = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            return salt;
        }

        public static byte[] HashText(string s, byte[] salt)
        {
            byte[] hashedPassword = new Argon2id(Encoding.UTF8.GetBytes(s))
            {
                Salt = salt,
                DegreeOfParallelism = 8,
                MemorySize = 1024 * 64,
                Iterations = 4
            }.GetBytes(32);

            return hashedPassword;
        }

        public static bool VerifyHash(string text, byte[] salt, byte[] hash) =>
            HashText(text, salt).SequenceEqual(hash);
    }
}
