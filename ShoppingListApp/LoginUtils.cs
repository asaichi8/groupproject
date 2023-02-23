using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ShoppingListApp
{
    public static class LoginUtils
    {
        private static readonly string INITIAL_FOLDER = "profiles";
        private static readonly string PASSWORD_FILENAME = "pass";
        private static readonly string CUR_DIR = Directory.GetCurrentDirectory();

        private static bool CreateFolder(string name, string dir = "")
        {
            try
            {
                if (dir == null)
                    dir = Directory.GetCurrentDirectory();

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

        public static bool CreateUserFolders(string username)
        {
            if (!CreateFolder(INITIAL_FOLDER))
                return false;

            string tarDir = Path.Combine(CUR_DIR, INITIAL_FOLDER);
            if (Directory.Exists(tarDir) || !CreateFolder(username, tarDir))
                return false;

            return true;
        }

        private static string GetProfilesDir()
        {
            return Path.Combine(CUR_DIR, INITIAL_FOLDER);
        }
        private static string GetUserDir(string username)
        {
            return Path.Combine(GetProfilesDir(), username);
        }

        public static bool CreatePasswordFile(string username, string hashedPassword)
        {
            try
            {
                string filePath = Path.Combine(GetUserDir(username), PASSWORD_FILENAME);

                if (File.Exists(filePath))
                    return false;

                // Create a new file & write the hashed password to it
                using (StreamWriter writer = File.CreateText(filePath))
                {
                    writer.Write(hashedPassword);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool isUsernameCharValid(char c)
        {
            Regex regexValidCharacter = new(@"^[A-Za-z0-9\b]");

            if (char.IsControl(c)) // allow shortcuts e.g. ctrl+c, ctrl+a etc.
                return true;

            return regexValidCharacter.IsMatch(c.ToString());
        }
    }
}
