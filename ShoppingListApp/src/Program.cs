using ShoppingListApp.src;
using System.Runtime.CompilerServices;

namespace ShoppingListApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // disallow more than one instance of the application, making it slightly more secure
            // https://odetocode.com/blogs/scott/archive/2004/08/20/the-misunderstood-mutex.aspx
            using Mutex mutex = new Mutex(false, "Global\\ShoppingListApp.exe");

            if (!mutex.WaitOne(0, false))
            {
                MessageBox.Show("Multiple instances of the software cannot be run concurrently.", "Instance already running",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CreateShops();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }

        /// <summary>
        /// Use this method to create new shops for the application.
        /// </summary>
        /// <remarks>
        /// The created Shop objects are added to the static <see cref="Shop.AllShops"/> list.
        /// </remarks>
        static private void CreateShops()
        {
            Shop tesco = new Shop("Tesco");
            Shop asda = new Shop("Asda");
            Shop sainsburys = new Shop("Sainsbury's");
        }
    }
}