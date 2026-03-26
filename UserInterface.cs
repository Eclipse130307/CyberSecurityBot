using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityBot
{
    public static class UserInterface
    {
        public static void DisplayAsciiArt()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine(@"
    ========================================
       CYBERSECURITY AWARENESS CHATBOT
    ========================================"
        );

            Console.ResetColor();
        }

        public static string GetUserName()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(name))
            {
                Console.Write("Name cannot be empty. Try again: ");
                name = Console.ReadLine();
            }

            Console.WriteLine($"Welcome, {name}!");
            return name;
        }
    }
}
