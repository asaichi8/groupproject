using System.Text.RegularExpressions;

namespace ShoppingListApp.src.Login
{
    /// <summary>
    /// Provides utility methods to create and manage user profiles and their passwords.
    /// </summary>
    public static class LoginUtils
    {
        private static readonly string CUR_DIR = Path.GetDirectoryName(Application.ExecutablePath);
        private const string INITIAL_FOLDER = "profiles";
        private const string PASSWORD_FILENAME = "cred";
        public const int PASSWORD_LENGTH_BYTES = 64;

        /// <summary>
        /// Creates a folder with a given name at a specified directory.
        /// </summary>
        /// <param name="name">The name of the folder.</param>
        /// <param name="dir">The directory where the folder should be created.</param>
        /// <returns>TRUE if success, FALSE if failed.</returns>
        private static bool CreateFolder(string name, string dir = "")
        {
            try
            {
                if (dir is null)
                    dir = CUR_DIR;

                string profilesPath = Path.Combine(dir, name);

                // CreateDirectory won't do anything if the folder already exists
                Directory.CreateDirectory(profilesPath);
            }
            catch
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Creates a folder inside the "profiles" folder based on a given username.
        /// </summary>
        /// <param name="username">The name of the folder.</param>
        /// <returns>TRUE if success, FALSE if user already exists, NULL if failed.</returns>
        public static bool? CreateUserFolders(string username)
        {
            if (!CreateFolder(INITIAL_FOLDER))
                return null;

            string profilesDir = GetProfilesDir();
            if (Directory.Exists(GetUserDir(username)))
                return false;

            if (!CreateFolder(username, profilesDir))
                return null;

            return true;
        }

        /// <returns>String containing the proposed profiles folder.</returns>
        public static string GetProfilesDir()
        {
            return Path.Combine(CUR_DIR, INITIAL_FOLDER);
        }
        /// <param name="username">The name of the folder.</param>
        /// <returns>String containing the proposed user folder for a given username.</returns>
        public static string GetUserDir(string username)
        {
            return Path.Combine(GetProfilesDir(), username);
        }

        /// <summary>
        /// Creates a file inside a user's folder containing the hashed password.
        /// </summary>
        /// <param name="username">Username of the password holder. Determines which folder the file is saved in.</param>
        /// <param name="hashedPassword">Byte array containing the password to be stored in the file.</param>
        /// <returns>TRUE if success, FALSE if failed.</returns>
        public static bool CreatePasswordFile(string username, byte[] hashedPassword)
        {
            try
            {
                string filePath = Path.Combine(GetUserDir(username), PASSWORD_FILENAME);

                if (File.Exists(filePath))
                    return false;

                // Create a new file & write the hashed password to it
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    fileStream.Write(hashedPassword, 0, hashedPassword.Length);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Reads the first 64 bytes of a user's password file.
        /// </summary>
        /// <param name="username">Username of the password holder. Determines which folder the file is read.</param>
        /// <returns>64-byte byte array containing the first 64 bytes of the file. Returns NULL if read failed.</returns>
        public static byte[]? ReadPasswordFile(string username)
        {
            try
            {
                string filePath = Path.Combine(GetUserDir(username), PASSWORD_FILENAME);

                if (!File.Exists(filePath))
                    return null;

                using (FileStream fileStream = new(filePath, FileMode.Open))
                {
                    byte[] passwordInBytes = new byte[PASSWORD_LENGTH_BYTES];
                    fileStream.Read(passwordInBytes, 0, PASSWORD_LENGTH_BYTES);

                    return passwordInBytes;
                }
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// <para>
        ///     Validates a given character and determines if it should be allowed in a user name.
        /// </para>
        /// <para>
        ///     Allowed characters:
        ///         a-z,
        ///         A-Z,
        ///         0-9,
        ///         Backspace,
        ///         Control
        /// </para>
        /// </summary>
        /// <param name="c">Character to be checked.</param>
        /// <returns>TRUE if character is valid, FALSE if not.</returns>
        public static bool IsUsernameCharValid(char c)
        {
            Regex regexValidCharacter = new(@"^[A-Za-z0-9\b]");

            if (char.IsControl(c)) // allow shortcuts e.g. ctrl+c, ctrl+a etc.
                return true;

            return regexValidCharacter.IsMatch(c.ToString());
        }



        /// <summary>
        /// Validates a password to ensure it meets minimum strength requirements.
        /// </summary>
        /// <param name="password">The password to validate.</param>
        /// <returns>TRUE if the password is strong enough, FALSE otherwise.</returns>
        public static bool ValidatePassword(string password)
        {
            // minimum password length
            const int MIN_LENGTH = 8;

            // password strength regex patterns
            const string LOWERCASE_PATTERN = @"[a-z]";
            const string UPPERCASE_PATTERN = @"[A-Z]";
            const string DIGIT_PATTERN = @"\d";
            const string SPECIAL_CHAR_PATTERN = @"[^\da-zA-Z]";

            // check minimum length
            if (password.Length < MIN_LENGTH)
                return false;

            // check each regex pattern
            if (!Regex.IsMatch(password, LOWERCASE_PATTERN)) // at least one lowercase letter
                return false;

            if (!Regex.IsMatch(password, UPPERCASE_PATTERN)) // at least one uppercase letter
                return false;

            if (!Regex.IsMatch(password, DIGIT_PATTERN)) // at least one digit
                return false;

            if (!Regex.IsMatch(password, SPECIAL_CHAR_PATTERN)) // at least one non alphanumeric character
                return false;


            return true;
        }
    }
}
