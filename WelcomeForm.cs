using System;
using System.Windows.Forms;

namespace CyberSecurityChatbot
{
    // Welcome screen logic
    public partial class WelcomeForm : Form
    {
        // Stores logged in username
        private string username;

        // Constructor receives logged in username
        public WelcomeForm(string loggedInUser)
        {
            // Stores username
            username = loggedInUser;

            // Loads designer controls
            InitializeComponent();

            // Plays welcome audio when welcome screen opens
            AudioPlayer.PlayGreeting();

            // Displays personalised welcome message
            lblWelcome.Text = "HELLO! " + username.ToUpper();
        }

        // Runs when Continue button is clicked
        private void btnContinue_Click(object sender, EventArgs e)
        {
            // Opens main chatbot screen
            MainForm mainForm = new MainForm(username);
            mainForm.Show();

            // Hides welcome screen
            Hide();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }
    }
}