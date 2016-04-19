using System;
using System.Windows.Forms;

namespace Artur_308_Shay_300
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form formFacebookMain = FormFactory.CreateForm(eTypeOfForm.MainForm, null);
            Application.Run(formFacebookMain);
        }
    }
}