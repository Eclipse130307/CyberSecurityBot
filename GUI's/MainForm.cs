using System;
using System.Drawing;
using System.Windows.Forms;

namespace CyberSecurityChatbot
{
    // Main chatbot window
    public partial class MainForm : Form
    {
        private Chatbot chatbot = new Chatbot();

        private string username;

        public MainForm(string loggedInUser)
        {
            username = loggedInUser;

            InitializeComponent();

            Shown += MainForm_Shown;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            AddBotMessage("Welcome back, " + username + ".");
            AddBotMessage("Ask me about passwords, phishing, scams, privacy, or safe browsing.");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            string userInput = txtUserInput.Text.Trim();

            if (string.IsNullOrWhiteSpace(userInput))
            {
                return;
            }

            AddUserMessage(userInput);

            string response = chatbot.GetResponse(userInput);

            AddBotMessage(response);

            txtUserInput.Text = "";

        }

        private void txtUserInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void AddBotMessage(string message)
        {
            AddMessageBubble("CyberBot", message, false);
        }

        private void AddUserMessage(string message)
        {
            AddMessageBubble("You", message, true);
        }

        private void AddMessageBubble(string senderName, string message, bool isUser)
        {
            int chatWidth = Math.Max(flpChat.ClientSize.Width - 80, 900);
            int bubbleWidth = 560;

            Panel messagePanel = new Panel();
            messagePanel.Width = chatWidth;
            messagePanel.Margin = new Padding(5, 12, 5, 12);
            messagePanel.BackColor = Color.Transparent;

            Label nameLabel = new Label();
            nameLabel.Text = senderName;
            nameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            nameLabel.AutoSize = true;

            Label bubble = new Label();
            bubble.Text = message;
            bubble.Font = new Font("Segoe UI", 10.5F);
            bubble.MaximumSize = new Size(bubbleWidth, 0);
            bubble.AutoSize = true;
            bubble.Padding = new Padding(15, 10, 15, 10);
            bubble.ForeColor = Color.White;

            if (isUser)
            {
                nameLabel.ForeColor = Color.FromArgb(255, 170, 220);
                nameLabel.Location = new Point(chatWidth - bubbleWidth - 20, 0);

                bubble.Location = new Point(chatWidth - bubbleWidth - 20, 28);
                bubble.BackColor = Color.FromArgb(210, 80, 170);
            }
            else
            {
                nameLabel.ForeColor = Color.FromArgb(0, 255, 255);
                nameLabel.Location = new Point(20, 0);

                bubble.Location = new Point(20, 28);
                bubble.BackColor = Color.FromArgb(90, 50, 150);
            }

            messagePanel.Controls.Add(nameLabel);
            messagePanel.Controls.Add(bubble);

            messagePanel.Height = bubble.Height + nameLabel.Height + 45;

            flpChat.Controls.Add(messagePanel);

            AddBottomSpacing();

            ScrollToBottom();
        }

        private void AddBottomSpacing()
        {
            if (flpChat.Controls.Count > 0 &&
                flpChat.Controls[flpChat.Controls.Count - 1].Name == "bottomSpacer")
            {
                flpChat.Controls.RemoveAt(flpChat.Controls.Count - 1);
            }

            Panel bottomSpacer = new Panel();
            bottomSpacer.Name = "bottomSpacer";
            bottomSpacer.Width = flpChat.ClientSize.Width - 80;
            bottomSpacer.Height = 60;
            bottomSpacer.BackColor = Color.Transparent;

            flpChat.Controls.Add(bottomSpacer);
        }

        private void ScrollToBottom()
        {
            flpChat.PerformLayout();

            if (flpChat.Controls.Count > 0)
            {
                flpChat.ScrollControlIntoView(
                    flpChat.Controls[flpChat.Controls.Count - 1]);
            }
        }
    }
}