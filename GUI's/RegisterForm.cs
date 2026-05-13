using System;
using System.Windows.Forms;

namespace CyberSecurityChatbot
{
    // Register screen logic
    public partial class RegisterForm : Form
    {
        // Constructor
        public RegisterForm()
        {
            // Loads designer controls
            InitializeComponent();
        }

        // Runs when Register button clicked
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Gets entered username
            string username = txtUsername.Text.Trim();

            // Gets entered password
            string password = txtPassword.Text.Trim();

            // Checks if fields are empty
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please enter both username and password.");

                return;
            }

            // Attempts to register user
            bool registered =
                UserManager.RegisterUser(
                    username,
                    password);

            // Successful registration
            if (registered)
            {
                MessageBox.Show(
                    "Registration successful. You can now log in.");

                // Opens login screen
                LoginForm loginForm =
                    new LoginForm();

                loginForm.Show();

                // Hides register screen
                Hide();
            }
            else
            {
                // Username already exists
                MessageBox.Show(
                    "Username already exists. Try another username.");
            }
        }

        // Back button logic
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Opens login screen
            LoginForm loginForm =
                new LoginForm();

            loginForm.Show();

            // Hides register screen
            Hide();
        }
    }
}