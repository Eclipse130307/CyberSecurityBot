using System;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CyberSecurityChatbotGUI
{
    internal static class Program
    {
        // Main entry point of the application
        [STAThread]
        static void Main()
        {
            // Initializes WinForms configuration
            ApplicationConfiguration.Initialize();

            // Starts the GUI form
            Application.Run(new MainForm());
        }
    }
}