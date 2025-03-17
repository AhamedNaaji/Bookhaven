using System;
using System.Windows.Forms;
using Bookhaven; // Ensure the correct namespace is used

namespace Bookhaven
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Start with the login form
            Form1 loginForm = new Form1();
            Application.Run(loginForm);
        }
    }
}