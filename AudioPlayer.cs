using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace CyberSecurityChatbotGUI
{
    public static class AudioPlayer
    {
        // Plays greeting audio
        public static void PlayGreeting()
        {
            try
            {
                // Path to WAV file
                string path = "greeting.wav";

                // Checks if file exists
                if (File.Exists(path))
                {
                    // Creates sound player
                    SoundPlayer player = new SoundPlayer(path);

                    // Plays audio
                    player.PlaySync();
                }
            }
            catch (Exception ex)
            {
                // Displays audio error
                MessageBox.Show("Audio error: " + ex.Message);
            }
        }
    }
}