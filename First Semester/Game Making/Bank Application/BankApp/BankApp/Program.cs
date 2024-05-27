using System;
using System.Windows.Forms;

namespace BankApp
{
    static class Program
    {
        // entry point
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
