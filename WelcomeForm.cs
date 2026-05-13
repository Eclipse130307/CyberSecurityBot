using System;
using System.Drawing;
using System.Windows.Forms;

namespace CyberSecurityChatbot
{
    public class WelcomeForm : Form
    {
        private string username;

        private Label lblWelcome;
        private Label lblMessage;
        private Button btnContinue;

        public WelcomeForm(string loggedInUser)
        {
            username = loggedInUser;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Text = "Welcome";
            WindowState = FormWindowState.Maximized;
            BackColor = Color.FromArgb(10, 10, 15);

            lblWelcome = new Label();
            lblWelcome.Text = "WELCOME, " + username.ToUpper();
            lblWelcome.ForeColor = Color.FromArgb(0, 255, 255);
            lblWelcome.Font = new Font("Bahnschrift SemiBold", 30F, FontStyle.Bold);
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(80, 130);

            lblMessage = new Label();
            lblMessage.Text = "Welcome to the Cybersecurity Awareness Chatbot.\n\n"
                            + "This chatbot helps you learn about online safety,\n"
                            + "passwords, phishing, scams, privacy, and safe browsing.";
            lblMessage.ForeColor = Color.White;
            lblMessage.Font = new Font("Segoe UI", 15F);
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(85, 225);

            btnContinue = new Button();
            btnContinue.Text = "Continue to Chatbot";
            btnContinue.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnContinue.BackColor = Color.FromArgb(210, 80, 170);
            btnContinue.ForeColor = Color.White;
            btnContinue.FlatStyle = FlatStyle.Flat;
            btnContinue.FlatAppearance.BorderSize = 0;
            btnContinue.Location = new Point(90, 410);
            btnContinue.Size = new Size(420, 50);
            btnContinue.Click += btnContinue_Click;

            Controls.Add(lblWelcome);
            Controls.Add(lblMessage);
            Controls.Add(btnContinue);
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(username);
            mainForm.Show();
            Hide();
        }
    }
}
