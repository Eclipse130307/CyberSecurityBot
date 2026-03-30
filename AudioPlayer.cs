using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityBot
{
    public static class AudioPlayer
    {
        public static void PlayGreeting()
        {
            try
            {
                // Play the embedded WAV from project resources
                var stream = Properties.Resources.Welcome_Greeting;

                if (stream != null)
                {
                    SoundPlayer player = new SoundPlayer(stream);
                    player.PlaySync();
                }
                else
                {
                    Console.WriteLine("Audio resource not found");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}