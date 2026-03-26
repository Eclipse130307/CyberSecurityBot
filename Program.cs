using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
          AudioPlayer.PlayGreeting();
        UserInterface.DisplayAsciiArt();

        string userName = UserInterface.GetUserName();
        Chatbot.StartChatbot(userName);
        }
    }
}
