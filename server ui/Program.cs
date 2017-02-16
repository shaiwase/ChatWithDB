using System;
using System.Windows.Forms;
 
namespace server_ui
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
            var GUI = new ServerGUI();
            ServerCommunicationManager cm = new ServerCommunicationManager(GUI);//create a new instance of server communication manager 
            Application.Run(GUI);
         }
    }
}
