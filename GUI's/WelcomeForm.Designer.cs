using System.Drawing;
using System.Windows.Forms;

namespace CyberSecurityChatbot
{
    // Designer section of WelcomeForm
    partial class WelcomeForm
    {
        // Container for controls
        private System.ComponentModel.IContainer components = null;

        // Labels
        private Label lblWelcome;
        private Label lblMessage;

        // Button
        private Button btnContinue;

        // Cleans up resources
        protected override void Dispose(bool disposing)
        {
            // Dispose components
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            // Base dispose
            base.Dispose(disposing);
        }

        // Creates GUI controls
        private void InitializeComponent()
        {
            // Initializes component container
            components = new System.ComponentModel.Container();

            // Creates controls
            lblWelcome = new Label();
            lblMessage = new Label();
            btnContinue = new Button();

            // Suspends layout while building UI
            SuspendLayout();

            // Form settings
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 600);
            Text = "Welcome";
            WindowState = FormWindowState.Maximized;
            BackColor = Color.FromArgb(10, 10, 15);

            // Welcome title
            lblWelcome.Text = "Test"; //Placeholder text, will be set in constructor
            lblWelcome.ForeColor = Color.FromArgb(0, 255, 255);
            lblWelcome.Font = new Font("Bahnschrift SemiBold", 30F, FontStyle.Bold);
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(80, 130);

            // Welcome message
            lblMessage.Text =
                "Welcome to the Cybersecurity Awareness Chatbot.\n" +
                "I am here to help you stay safe online";

            lblMessage.ForeColor = Color.White;
            lblMessage.Font = new Font("Segoe UI", 15F);
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(85, 225);

            // Continue button
            btnContinue.Text = "Continue to Chatbot";
            btnContinue.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnContinue.BackColor = Color.FromArgb(210, 80, 170);
            btnContinue.ForeColor = Color.White;
            btnContinue.FlatStyle = FlatStyle.Flat;
            btnContinue.FlatAppearance.BorderSize = 0;
            btnContinue.Location = new Point(90, 410);
            btnContinue.Size = new Size(420, 50);

            // IMPORTANT: connects button to click method
            btnContinue.Click += btnContinue_Click;

            // Adds controls to form
            Controls.Add(lblWelcome);
            Controls.Add(lblMessage);
            Controls.Add(btnContinue);

            // Resumes layout
            ResumeLayout(false);
            PerformLayout();
        }
    }
}