using ShoppingListApp.src;
using System.Runtime.CompilerServices;

namespace ShoppingListApp
{
    internal static class Program
    {
        //public static object ApplicationConfiguration { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CreateShops();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();   // Updating to C# version 8.0 and above causes the system not to detect to it.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }

        // creating an instance of a Shop object will add it to a static list
        static private void CreateShops()
        {
            Shop tesco = new Shop("Tesco");
            Shop asda = new Shop("Asda");
            Shop sainsburys = new Shop("Sainsbury's");
        }
    }
}