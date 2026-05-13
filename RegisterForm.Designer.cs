using System.Drawing;
using System.Windows.Forms;

namespace CyberSecurityChatbot
{
    // Designer section of RegisterForm
    partial class RegisterForm
    {
        // Container for controls
        private System.ComponentModel.IContainer components = null;

        // Labels
        private Label lblTitle;
        private Label lblUsername;
        private Label lblPassword;

        // Textboxes
        private TextBox txtUsername;
        private TextBox txtPassword;

        // Buttons
        private Button btnRegister;
        private Button btnBack;

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
            components =
                new System.ComponentModel.Container();

            // Creates controls
            lblTitle = new Label();

            lblUsername = new Label();
            lblPassword = new Label();

            txtUsername = new TextBox();
            txtPassword = new TextBox();

            btnRegister = new Button();
            btnBack = new Button();

            // Suspends layout while building UI
            SuspendLayout();

            // Form settings
            AutoScaleMode =
                AutoScaleMode.Font;

            ClientSize =
                new Size(900, 600);

            Text = "Register";

            WindowState =
                FormWindowState.Maximized;

            BackColor =
                Color.FromArgb(10, 10, 15);

            // Center position
            int centerX = 560; // Adjusted for form size and control widths

            // REGISTER title
            lblTitle.Text = "REGISTER";

            lblTitle.ForeColor =
                Color.FromArgb(0, 255, 255);

            lblTitle.Font =
                new Font(
                    "Bahnschrift SemiBold",
                    30F,
                    FontStyle.Bold);

            lblTitle.AutoSize = true;

            // Centered title
            lblTitle.Location =
                new Point(centerX, 120);

            // Username label
            lblUsername.Text = "Username";

            lblUsername.ForeColor =
                Color.White;

            lblUsername.Font =
                new Font(
                    "Segoe UI",
                    12F,
                    FontStyle.Bold);

            lblUsername.AutoSize = true;

            lblUsername.Location =
                new Point(centerX, 240);

            // Username textbox
            txtUsername.Font =
                new Font(
                    "Segoe UI",
                    13F);

            txtUsername.BackColor =
                Color.FromArgb(28, 20, 40);

            txtUsername.ForeColor =
                Color.White;

            txtUsername.BorderStyle =
                BorderStyle.FixedSingle;

            txtUsername.Location =
                new Point(centerX, 275);

            txtUsername.Size =
                new Size(420, 35);

            // Password label
            lblPassword.Text = "Password";

            lblPassword.ForeColor =
                Color.White;

            lblPassword.Font =
                new Font(
                    "Segoe UI",
                    12F,
                    FontStyle.Bold);

            lblPassword.AutoSize = true;

            lblPassword.Location =
                new Point(centerX, 345);

            // Password textbox
            txtPassword.Font =
                new Font(
                    "Segoe UI",
                    13F);

            txtPassword.BackColor =
                Color.FromArgb(28, 20, 40);

            txtPassword.ForeColor =
                Color.White;

            txtPassword.BorderStyle =
                BorderStyle.FixedSingle;

            txtPassword.PasswordChar = '*';

            txtPassword.Location =
                new Point(centerX, 380);

            txtPassword.Size =
                new Size(420, 35);

            // Register button
            btnRegister.Text = "Register";

            btnRegister.Font =
                new Font(
                    "Segoe UI",
                    13F,
                    FontStyle.Bold);

            btnRegister.BackColor =
                Color.FromArgb(210, 80, 170);

            btnRegister.ForeColor =
                Color.White;

            btnRegister.FlatStyle =
                FlatStyle.Flat;

            btnRegister.FlatAppearance.BorderSize = 0;

            btnRegister.Location =
                new Point(centerX, 470);

            btnRegister.Size =
                new Size(420, 50);

            // Register click event
            btnRegister.Click += btnRegister_Click;

            // Back button
            btnBack.Text =
                "Back to Login";

            btnBack.Font =
                new Font(
                    "Segoe UI",
                    11F,
                    FontStyle.Bold);

            btnBack.BackColor =
                Color.FromArgb(90, 50, 150);

            btnBack.ForeColor =
                Color.White;

            btnBack.FlatStyle =
                FlatStyle.Flat;

            btnBack.FlatAppearance.BorderSize = 0;

            btnBack.Location =
                new Point(centerX, 545);

            btnBack.Size =
                new Size(420, 45);

            // Back button click event
            btnBack.Click += btnBack_Click;

            // Adds controls to form
            Controls.Add(lblTitle);

            Controls.Add(lblUsername);
            Controls.Add(txtUsername);

            Controls.Add(lblPassword);
            Controls.Add(txtPassword);

            Controls.Add(btnRegister);
            Controls.Add(btnBack);

            // Resumes layout
            ResumeLayout(false);

            PerformLayout();
        }
    }
}