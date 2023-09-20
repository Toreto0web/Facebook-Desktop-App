using System;
using System.Windows.Forms;

namespace WinFormUI
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            try
            {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            }
            catch(Exception)
            {
            }
        }
    }
}
