using System;
using System.Windows.Forms;
using FiguresBase.FileManager;
using FiguresForm;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainFiguresForm form = new MainFiguresForm();
            FileManager manager = new FileManager();
            MainPresenter mainPresenter = new MainPresenter(form, manager);

            Application.Run(form);
        }
    }
}
