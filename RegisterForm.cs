using System;
using System.Drawing;
using System.Windows.Forms;

namespace CyberSecurityChatbot
{
    public class RegisterForm : Form
    {
        private Label lblTitle;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnRegister;
        private Button btnBack;

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Text = "Register";
            WindowState = FormWindowState.Maximized;
            BackColor = Color.FromArgb(10, 10, 15);

            lblTitle = new Label();
            lblTitle.Text = "REGISTER";
            lblTitle.ForeColor = Color.FromArgb(0, 255, 255);
            lblTitle.Font = new Font("Bahnschrift SemiBold", 30F, FontStyle.Bold);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(80, 100);

            lblUsername = new Label();
            lblUsername.Text = "Username";
            lblUsername.ForeColor = Color.White;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(85, 190);

            txtUsername = new TextBox();
            txtUsername.Font = new Font("Segoe UI", 13F);
            txtUsername.BackColor = Color.FromArgb(28, 20, 40);
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(90, 225);
            txtUsername.Size = new Size(420, 35);

            lblPassword = new Label();
            lblPassword.Text = "Password";
            lblPassword.ForeColor = Color.White;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(85, 280);

            txtPassword = new TextBox();
            txtPassword.Font = new Font("Segoe UI", 13F);
            txtPassword.BackColor = Color.FromArgb(28, 20, 40);
            txtPassword.ForeColor = Color.White;
            txtPassword.PasswordChar = '*';
            txtPassword.Location = new Point(90, 315);
            txtPassword.Size = new Size(420, 35);

            btnRegister = new Button();
            btnRegister.Text = "Register";
            btnRegister.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnRegister.BackColor = Color.FromArgb(210, 80, 170);
            btnRegister.ForeColor = Color.White;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.Location = new Point(90, 380);
            btnRegister.Size = new Size(420, 45);
            btnRegister.Click += btnRegister_Click;

            btnBack = new Button();
            btnBack.Text = "Back to Login";
            btnBack.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnBack.BackColor = Color.FromArgb(90, 50, 150);
            btnBack.ForeColor = Color.White;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.Location = new Point(90, 445);
            btnBack.Size = new Size(420, 40);
            btnBack.Click += btnBack_Click;

            Controls.Add(lblTitle);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnRegister);
            Controls.Add(btnBack);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            bool registered = UserManager.RegisterUser(username, password);

            if (registered)
            {
                MessageBox.Show("Registration successful. You can now log in.");

                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Username already exists. Try another username.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            Hide();
        }
    }
}