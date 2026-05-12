using CyberSecurityBot;
using System;
using System.Windows.Forms;

namespace CyberSecurityChatbot
{
    public partial class MainForm : Form
    {
        // Creates chatbot object
        private Chatbot chatbot = new Chatbot();

        public MainForm()
        {
            // Loads all GUI controls
            InitializeComponent();

            // Plays greeting audio
            AudioPlayer.PlayGreeting();

            // Welcome message
            rtbChat.AppendText("Bot: Welcome to the Cybersecurity Awareness Chatbot.\n");
            rtbChat.AppendText("Bot: Ask me about passwords, phishing, scams, privacy, or safe browsing.\n\n");
        }

        // Runs when Send button is clicked
        private void btnSend_Click(object sender, EventArgs e)
        {
            // Gets user message
            string userInput = txtUserInput.Text;

            // Displays user message
            rtbChat.AppendText("You: " + userInput + "\n");

            // Gets chatbot response
            string response = chatbot.GetResponse(userInput);

            // Displays chatbot response
            rtbChat.AppendText("Bot: " + response + "\n\n");

            // Clears textbox
            txtUserInput.Clear();

            // Returns cursor to textbox
            txtUserInput.Focus();
        }
    }
}
