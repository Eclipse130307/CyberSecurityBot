using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace CyberSecurityChatbot
{
    public static class AudioPlayer
    {
        // Plays welcome greeting audio
        public static void PlayGreeting()
        {
            try
            {
                // Gets audio stream from resources
                UnmanagedMemoryStream stream =
                CyberSecurityBot.Properties.Resources.Welcome_Greeting;

                // Creates sound player
                SoundPlayer player =
                    new SoundPlayer(stream);

                // Loads audio
                player.Load();

                // Plays audio
                player.Play();
            }
            catch (Exception ex)
            {
                // Displays audio error
                MessageBox.Show(
                    "Audio error: " + ex.Message);
            }
        }
    }
}