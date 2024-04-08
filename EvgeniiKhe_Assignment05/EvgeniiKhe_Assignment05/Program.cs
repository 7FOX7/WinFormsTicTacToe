using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvgeniiKhe_Assignment05
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IntroPage introPage = new IntroPage();
            Application.Run(introPage);
            if(introPage.OpenMainMenuPage == true)
            {
                Application.Run(new MainMenuPage());
            }
        }
    }
}
