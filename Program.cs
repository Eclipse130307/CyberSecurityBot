using System;
using System.Windows.Forms;

namespace CyberSecurityChatbot
{
    internal static class Program
    {
        // Main entry point of the application
        [STAThread]
        static void Main()
        {
            // Enables visual styles for WinForms
            Application.EnableVisualStyles();

            // Sets compatible text rendering
            Application.SetCompatibleTextRenderingDefault(false);

            // Starts the main GUI form
            Application.Run(new MainForm());
        }
    }
}