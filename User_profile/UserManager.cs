using System.IO;

namespace CyberSecurityChatbot
{
    public static class UserManager
    {
        // File used to store registered users
        private static string filePath = "users.txt";

        // Registers a new user
        public static bool RegisterUser(string username, string password)
        {
            // Create file if it does not exist
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            string[] users = File.ReadAllLines(filePath);

            // Check if username already exists
            foreach (string user in users)
            {
                string[] details = user.Split(',');

                if (details[0] == username)
                {
                    return false;
                }
            }

            // Save user details
            File.AppendAllText(filePath, username + "," + password + "\n");

            return true;
        }

        // Checks login details
        public static bool LoginUser(string username, string password)
        {
            if (!File.Exists(filePath))
            {
                return false;
            }

            string[] users = File.ReadAllLines(filePath);

            foreach (string user in users)
            {
                string[] details = user.Split(',');

                if (details.Length == 2 &&
                    details[0] == username &&
                    details[1] == password)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
