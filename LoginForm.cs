using System;
using System.Windows.Forms;

namespace CyberSecurityChatbot
{
    // Login screen logic
    public partial class LoginForm : Form
    {
        // Constructor
        public LoginForm()
        {
            // Loads designer controls
            InitializeComponent();
        }

        // Runs when Login button is clicked
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Gets entered username
            string username = txtUsername.Text.Trim();

            // Gets entered password
            string password = txtPassword.Text.Trim();

            // Checks if fields are empty
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            // Checks if user exists
            if (UserManager.LoginUser(username, password))
            {
                // Opens welcome screen
                WelcomeForm welcomeForm = new WelcomeForm(username);
                welcomeForm.Show();

                // Hides login screen
                Hide();
            }
            else
            {
                // Invalid login message
                MessageBox.Show("Invalid username or password.");
            }
        }

        // Runs when Create Account button is clicked
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Opens register screen
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();

            // Hides login screen
            Hide();
        }
    }
}