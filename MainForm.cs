using System;
using System.Drawing;
using System.Windows.Forms;

namespace CyberSecurityChatbot
{
    public partial class MainForm : Form
    {
        private Chatbot chatbot = new Chatbot();
        private string placeholderText = "Type your message...";

        public MainForm()
        {
            InitializeComponent();

            AudioPlayer.PlayGreeting();

            AddPlaceholder(null, null);

            Shown += MainForm_Shown;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            AddBotMessage("Welcome to the Cybersecurity Awareness Chatbot.");
            AddBotMessage("Ask me about passwords, phishing, scams, privacy, or safe browsing.");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string userInput = txtUserInput.Text;

            if (string.IsNullOrWhiteSpace(userInput) || userInput == placeholderText)
            {
                return;
            }

            AddUserMessage(userInput);

            string response = chatbot.GetResponse(userInput);

            AddBotMessage(response);

            txtUserInput.Text = "";
            AddPlaceholder(null, null);
            txtUserInput.Focus();
        }

        private void txtUserInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            if (txtUserInput.Text == placeholderText)
            {
                txtUserInput.Text = "";
                txtUserInput.ForeColor = Color.White;
            }
        }

        private void AddPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserInput.Text))
            {
                txtUserInput.Text = placeholderText;
                txtUserInput.ForeColor = Color.FromArgb(170, 160, 190);
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
            int chatWidth = Math.Max(flpChat.ClientSize.Width - 60, 900);
            int bubbleWidth = 520;

            Panel messagePanel = new Panel();
            messagePanel.Width = chatWidth;
            messagePanel.AutoSize = true;
            messagePanel.Margin = new Padding(5, 10, 5, 10);
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

                // Moves user label and textbox further right
                nameLabel.Location = new Point(chatWidth - bubbleWidth - 10, 0);
                bubble.Location = new Point(chatWidth - bubbleWidth - 10, 25);

                bubble.BackColor = Color.FromArgb(210, 80, 170);
            }
            else
            {
                // CyberBot name recoloured to same blue as title
                nameLabel.ForeColor = Color.FromArgb(0, 255, 255);
                nameLabel.Location = new Point(20, 0);

                bubble.Location = new Point(20, 25);
                bubble.BackColor = Color.FromArgb(90, 50, 150);
            }

            messagePanel.Controls.Add(nameLabel);
            messagePanel.Controls.Add(bubble);

            messagePanel.Height = bubble.Height + 45;

            flpChat.Controls.Add(messagePanel);

            ScrollToBottom();
        }

        private void ScrollToBottom()
        {
            flpChat.PerformLayout();
            flpChat.VerticalScroll.Value = flpChat.VerticalScroll.Maximum;
        }
    }
}