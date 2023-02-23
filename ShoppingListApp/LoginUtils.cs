using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ShoppingListApp
{
    public static class LoginUtils
    {
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
            const string INITIAL_FOLDER = "profiles";
            string curDir = Directory.GetCurrentDirectory();

            if (!CreateFolder(INITIAL_FOLDER))
                return false;

            string tarDir = Path.Combine(curDir, INITIAL_FOLDER);
            if (!CreateFolder(username, tarDir))
                return false;

            return true;
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
