using FiguresBase.FileManager;
using FiguresForm;
using System;
using System.Windows.Forms;
namespace Figures
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //MainFiguresForm form = new MainFiguresForm();
            //FileManager manager = new FileManager();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFiguresForm());
        }
    }
}
