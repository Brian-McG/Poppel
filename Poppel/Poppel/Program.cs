using Poppel.PresentationLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Poppel.CustomerMangement;
using Poppel.Order;
using Poppel.PresentationLayer;

namespace Poppel
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           //Application.Run(new CustomerManagement(new CustomerManangementController()));
            Poppel.PresentationLayer.Login login = new Poppel.PresentationLayer.Login();
          login.StartPosition = FormStartPosition.CenterScreen;
           login.Show();
            Application.Run();
        }
    }
}
