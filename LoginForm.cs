using System;
using System.Drawing;
using System.Windows.Forms;

namespace CyberSecurityChatbot
{
    public class LoginForm : Form
    {
        private Label lblTitle;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnRegister;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            BackColor = Color.FromArgb(10, 10, 15);

            lblTitle = new Label();
            lblTitle.Text = "LOGIN";
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

            btnLogin = new Button();
            btnLogin.Text = "Login";
            btnLogin.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnLogin.BackColor = Color.FromArgb(210, 80, 170);
            btnLogin.ForeColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Location = new Point(90, 380);
            btnLogin.Size = new Size(420, 45);
            btnLogin.Click += btnLogin_Click;

            btnRegister = new Button();
            btnRegister.Text = "Create New Account";
            btnRegister.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegister.BackColor = Color.FromArgb(90, 50, 150);
            btnRegister.ForeColor = Color.White;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.Location = new Point(90, 445);
            btnRegister.Size = new Size(420, 40);
            btnRegister.Click += btnRegister_Click;

            Controls.Add(lblTitle);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(btnRegister);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (UserManager.LoginUser(username, password))
            {
                WelcomeForm welcomeForm = new WelcomeForm(username);
                welcomeForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            Hide();
        }
    }
}