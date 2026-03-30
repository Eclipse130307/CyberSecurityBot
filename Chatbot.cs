using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
                    Console.WriteLine("Bot: My purpose is to help you understand basic cybersecurity practices so you can protect your personal information, devices, and online accounts from threats.");
                }
                else if (input.Contains("ask"))
                {
                    Console.WriteLine("Bot: Ask about phishing, passwords, and safe browsing.");
                }
                else if (input.Contains("password"))
                {
                    Console.WriteLine("Bot: A strong password should be at least 12 characters long and include a mix of uppercase letters, lowercase letters, numbers, and symbols. Avoid using personal information, and never reuse the same password across multiple accounts.");
                }
                else if (input.Contains("phishing"))
                {
                    Console.WriteLine("Bot: Phishing is a type of cyber attack where attackers try to trick you into revealing sensitive information like passwords or banking details. Be cautious of emails or messages that create urgency, contain suspicious links, or ask for personal information.");
                }
                else if (input.Contains("browsing"))
                {
                    Console.WriteLine("Bot: Safe browsing means only visiting secure websites that use HTTPS (Looking for HTTPS in the website URL), avoiding clicking on unknown links, and keeping your browser updated. You should also avoid downloading files from untrusted sources.");
                }
                else if (input.Contains("malware"))
                {
                    Console.WriteLine("Bot: Malware is harmful software designed to damage or gain unauthorized access to your system. You can protect yourself by installing antivirus software, avoiding suspicious downloads, and keeping your system updated.");
                }
                else if (input.Contains("vpn"))
                {
                    Console.WriteLine("Bot: A VPN (Virtual Private Network) encrypts your internet connection and helps protect your privacy, especially when using public Wi-Fi. It makes it harder for attackers to intercept your data.");
                }
                else if (input.Contains("2fa") || input.Contains("two factor"))
                {
                    Console.WriteLine("Bot: Two-factor authentication (2FA) adds an extra layer of security by requiring a second verification step, such as a code sent to your phone. It greatly reduces the risk of unauthorized access.");
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
