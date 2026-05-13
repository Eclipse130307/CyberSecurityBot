using System;
using System.Windows.Forms;

namespace CyberSecurityChatbot
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // App starts at login screen
            Application.Run(new LoginForm());
        }
    }
}