using System;
using System.Drawing;
using System.Windows.Forms;

namespace CyberSecurityChatbot
{
    // Main chatbot window
    public partial class MainForm : Form
    {
        // Chatbot object
        private Chatbot chatbot = new Chatbot();

        // Stores logged in username
        private string username;

        // Tracks whether placeholder is currently active
        private bool isPlaceholderActive = true;

        // Constructor
        public MainForm(string loggedInUser)
        {
            // Stores username
            username = loggedInUser;

            // Loads GUI controls
            InitializeComponent();

            // Displays welcome messages after form loads
            Shown += MainForm_Shown;
        }

        // Welcome messages
        private void MainForm_Shown(object sender, EventArgs e)
        {
            AddBotMessage("Welcome back, " + username + ".");
            AddBotMessage("Ask me about passwords, phishing, scams, privacy, or safe browsing.");
        }

        // Runs when Send button clicked
        private void btnSend_Click(object sender, EventArgs e)
        {
            // Prevents sending placeholder text
            if (isPlaceholderActive)
            {
                return;
            }

            // Gets user message
            string userInput = txtUserInput.Text.Trim();

            // Prevents empty messages
            if (string.IsNullOrWhiteSpace(userInput))
            {
                return;
            }

            // Displays user message
            AddUserMessage(userInput);

            // Gets chatbot response
            string response = chatbot.GetResponse(userInput);

            // Displays bot response
            AddBotMessage(response);

            // Clears textbox
            txtUserInput.Text = "";

            // Returns cursor
            txtUserInput.Focus();
        }

        // Allows Enter key to send
        private void txtUserInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend_Click(sender, e);

                // Prevents beep sound
                e.SuppressKeyPress = true;
            }
        }

        // Removes placeholder text
        private void RemovePlaceholder(object sender, EventArgs e)
        {
            if (isPlaceholderActive)
            {
                txtUserInput.Text = "";
                txtUserInput.ForeColor = Color.White;
                isPlaceholderActive = false;
            }
        }

        // Adds chatbot message
        private void AddBotMessage(string message)
        {
            AddMessageBubble("CyberBot", message, false);
        }

        // Adds user message
        private void AddUserMessage(string message)
        {
            AddMessageBubble("You", message, true);
        }

        // Creates message bubbles
        private void AddMessageBubble(string senderName, string message, bool isUser)
        {
            // Width of chat area
            int chatWidth = Math.Max(flpChat.Width - 60, 900);

            // Bubble width
            int bubbleWidth = 520;

            // Message panel
            Panel messagePanel = new Panel();
            messagePanel.Width = chatWidth;
            messagePanel.AutoSize = true;
            messagePanel.Margin = new Padding(5, 10, 5, 10);
            messagePanel.BackColor = Color.Transparent;

            // Sender name label
            Label nameLabel = new Label();
            nameLabel.Text = senderName;
            nameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            nameLabel.AutoSize = true;

            // Message bubble
            Label bubble = new Label();
            bubble.Text = message;
            bubble.Font = new Font("Segoe UI", 10.5F);
            bubble.MaximumSize = new Size(bubbleWidth, 0);
            bubble.AutoSize = true;
            bubble.Padding = new Padding(15, 10, 15, 10);
            bubble.ForeColor = Color.White;

            // User messages
            if (isUser)
            {
                nameLabel.ForeColor = Color.FromArgb(255, 170, 220);
                nameLabel.Location = new Point(chatWidth - bubbleWidth - 10, 0);

                bubble.Location = new Point(chatWidth - bubbleWidth - 10, 25);
                bubble.BackColor = Color.FromArgb(210, 80, 170);
            }
            else
            {
                nameLabel.ForeColor = Color.FromArgb(0, 255, 255);
                nameLabel.Location = new Point(20, 0);

                bubble.Location = new Point(20, 25);
                bubble.BackColor = Color.FromArgb(90, 50, 150);
            }

            // Adds controls
            messagePanel.Controls.Add(nameLabel);
            messagePanel.Controls.Add(bubble);

            // Dynamic height
            messagePanel.Height = bubble.Height + 45;

            // Adds to chat
            flpChat.Controls.Add(messagePanel);

            // Scrolls down
            ScrollToBottom();
        }

        // Auto scroll
        private void ScrollToBottom()
        {
            flpChat.PerformLayout();
            flpChat.VerticalScroll.Value = flpChat.VerticalScroll.Maximum;
        }
    }
}