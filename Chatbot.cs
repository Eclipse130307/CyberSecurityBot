using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityBot
{
    public static class Chatbot
    {
        public static void StartChatbot(string userName)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nYou: ");
                string input = Console.ReadLine().ToLower();

                Console.ForegroundColor = ConsoleColor.Green;

                if (input.Contains("how are you"))
                {
                    Console.WriteLine($"Bot: I'm doing well, {userName}!");
                }
                else if (input.Contains("purpose"))
                {
                    Console.WriteLine("Bot: I help users stay safe online.");
                }
                else if (input.Contains("ask"))
                {
                    Console.WriteLine("Bot: Ask about phishing, passwords, and safe browsing.");
                }
                else if (input.Contains("password"))
                {
                    Console.WriteLine("Bot: Use strong passwords.");
                }
                else if (input.Contains("phishing"))
                {
                    Console.WriteLine("Bot: Phishing steals personal info.");
                }
                else if (input.Contains("browsing"))
                {
                    Console.WriteLine("Bot: Use secure websites (https).");
                }
                else if (input == "exit")
                {
                    Console.WriteLine("Bot: Goodbye!");
                    break;
                }
                else if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Bot: Please enter something.");
                }
                else
                {
                    Console.WriteLine("Bot: I didn’t understand that.");
                }
            }
        }
    }
}
