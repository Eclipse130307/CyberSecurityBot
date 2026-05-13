using System;
using System.Drawing;
using System.Windows.Forms;

namespace CyberSecurityChatbot
{
    public partial class MainForm : Form
    {
        // Chatbot object
        private Chatbot chatbot = new Chatbot();

        // Stores logged in username
        private string username;

        // Placeholder text
        private string placeholderText = "Type your message...";

        // Constructor receives logged in username
        public MainForm(string loggedInUser)
        {
            username = loggedInUser;

            InitializeComponent();

            // Adds placeholder text
            AddPlaceholder(null, null);

            // Displays welcome messages after form loads
            Shown += MainForm_Shown;
        }

        // Welcome messages shown when chatbot opens
        private void MainForm_Shown(object sender, EventArgs e)
        {
            AddBotMessage("Welcome back, " + username + ".");
            AddBotMessage("Ask me about passwords, phishing, scams, privacy, or safe browsing.");
        }

        // Runs when Send button is clicked
        private void btnSend_Click(object sender, EventArgs e)
        {
            string userInput = txtUserInput.Text;

            // Prevents empty messages
            if (string.IsNullOrWhiteSpace(userInput) || userInput == placeholderText)
            {
                return;
            }

            // Displays user message
            AddUserMessage(userInput);

            // Gets chatbot response
            string response = chatbot.GetResponse(userInput);

            // Displays chatbot response
            AddBotMessage(response);

            // Clears textbox
            txtUserInput.Text = "";

            // Restores placeholder
            AddPlaceholder(null, null);

            // Returns cursor to textbox
            txtUserInput.Focus();
        }

        // Allows Enter key to send message
        private void txtUserInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend_Click(sender, e);

                // Prevents Windows beep sound
                e.SuppressKeyPress = true;
            }
        }

        // Removes placeholder when textbox selected
        private void RemovePlaceholder(object sender, EventArgs e)
        {
            if (txtUserInput.Text == placeholderText)
            {
                txtUserInput.Text = "";
                txtUserInput.ForeColor = Color.White;
            }
        }

        // Restores placeholder when textbox empty
        private void AddPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserInput.Text))
            {
                txtUserInput.Text = placeholderText;
                txtUserInput.ForeColor = Color.FromArgb(170, 160, 190);
            }
        }

        // Adds chatbot message bubble
        private void AddBotMessage(string message)
        {
            AddMessageBubble("CyberBot", message, false);
        }

        // Adds user message bubble
        private void AddUserMessage(string message)
        {
            AddMessageBubble("You", message, true);
        }

        // Creates message bubbles
        private void AddMessageBubble(string senderName, string message, bool isUser)
        {
            // Width of chat area
            int chatWidth = Math.Max(flpChat.ClientSize.Width - 60, 900);

            // Width of bubble
            int bubbleWidth = 520;

            // Main panel holding message
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

            // Prevents vertical text
            bubble.MaximumSize = new Size(bubbleWidth, 0);

            bubble.AutoSize = true;
            bubble.Padding = new Padding(15, 10, 15, 10);
            bubble.ForeColor = Color.White;

            // User messages
            if (isUser)
            {
                // User label colour
                nameLabel.ForeColor = Color.FromArgb(255, 170, 220);

                // Position further right
                nameLabel.Location = new Point(chatWidth - bubbleWidth - 10, 0);

                // User bubble position
                bubble.Location = new Point(chatWidth - bubbleWidth - 10, 25);

                // Pink user bubble
                bubble.BackColor = Color.FromArgb(210, 80, 170);
            }
            else
            {
                // CyberBot name colour
                nameLabel.ForeColor = Color.FromArgb(0, 255, 255);

                // Left side position
                nameLabel.Location = new Point(20, 0);

                // Bot bubble position
                bubble.Location = new Point(20, 25);

                // Purple bot bubble
                bubble.BackColor = Color.FromArgb(90, 50, 150);
            }

            // Add controls
            messagePanel.Controls.Add(nameLabel);
            messagePanel.Controls.Add(bubble);

            // Dynamic height
            messagePanel.Height = bubble.Height + 45;

            // Add message to chat
            flpChat.Controls.Add(messagePanel);

            // Auto scroll
            ScrollToBottom();
        }

        // Scrolls chat to newest message
        private void ScrollToBottom()
        {
            flpChat.PerformLayout();
            flpChat.VerticalScroll.Value = flpChat.VerticalScroll.Maximum;
        }
    }
}