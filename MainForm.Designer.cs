using System.Drawing;
using System.Windows.Forms;

namespace CyberSecurityChatbot
{
    partial class MainForm
    {
        // Stores form components
        private System.ComponentModel.IContainer components = null;

        // Chat display area
        private RichTextBox rtbChat;

        // User input textbox
        private TextBox txtUserInput;

        // Send button
        private Button btnSend;

        // Title label
        private Label lblTitle;

        // Cleans up resources
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        // Creates GUI controls and positions them
        private void InitializeComponent()
        {
            rtbChat = new RichTextBox();
            txtUserInput = new TextBox();
            btnSend = new Button();
            lblTitle = new Label();

            SuspendLayout();

            // Title label settings
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 20);
            lblTitle.Text = "Cybersecurity Awareness Chatbot";

            // Chat area settings
            rtbChat.BackColor = Color.White;
            rtbChat.Font = new Font("Segoe UI", 10F);
            rtbChat.Location = new Point(20, 70);
            rtbChat.ReadOnly = true;
            rtbChat.Size = new Size(640, 300);

            // Input textbox settings
            txtUserInput.Font = new Font("Segoe UI", 10F);
            txtUserInput.Location = new Point(20, 390);
            txtUserInput.Size = new Size(520, 25);

            // Send button settings
            btnSend.BackColor = Color.LightSeaGreen;
            btnSend.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSend.Location = new Point(560, 388);
            btnSend.Size = new Size(100, 30);
            btnSend.Text = "Send";

            // Connects button click event
            btnSend.Click += btnSend_Click;

            // Main form settings
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(684, 441);
            Text = "Cybersecurity Awareness Chatbot";

            // Adds controls to form
            Controls.Add(lblTitle);
            Controls.Add(rtbChat);
            Controls.Add(txtUserInput);
            Controls.Add(btnSend);

            ResumeLayout(false);
            PerformLayout();
        }
    }
}