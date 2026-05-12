using CyberSecurityChatbot;

namespace CyberSecurityChatbot
{
    // Delegate used for chatbot responses
    public delegate string ResponseDelegate(string input);

    public class Chatbot
    {
        // Helper objects
        private ResponseManager responseManager = new ResponseManager();
        private MemoryManager memory = new MemoryManager();
        private ToneAnalyzer ToneAnalyzer = new ToneAnalyzer();

        // Main response method
        public string GetResponse(string input)
        {
            // Creates delegate object
            ResponseDelegate responseHandler = ProcessInput;

            // Calls delegate
            return responseHandler(input);
        }

        // Processes user input
        private string ProcessInput(string input)
        {
            // Handles empty messages
            if (string.IsNullOrWhiteSpace(input))
            {
                return "Please enter a message.";
            }

            // Converts input to lowercase
            input = input.ToLower();

            // Detects emotion
            string sentiment = ToneAnalyzer.DetectTone(input);

            // Stores user name
            if (input.Contains("my name is"))
            {
                memory.UserName = input.Replace("my name is", "").Trim();

                return "Nice to meet you, " + memory.UserName + ".";
            }

            // Stores favourite topic
            if (input.Contains("interested in"))
            {
                memory.FavouriteTopic = input.Replace("interested in", "").Trim();

                return "I will remember that you are interested in " + memory.FavouriteTopic + ".";
            }

            // Memory recall
            if (input.Contains("remember"))
            {
                return "Your favourite topic is " + memory.FavouriteTopic + ".";
            }

            // Continues conversation
            if (input.Contains("tell me more") || input.Contains("another tip"))
            {
                if (memory.LastTopic != "")
                {
                    return responseManager.GetRandomResponse(memory.LastTopic);
                }
            }

            // Password topic
            if (input.Contains("password"))
            {
                memory.LastTopic = "password";

                return AddSentiment(sentiment)
                    + responseManager.GetRandomResponse("password");
            }

            // Phishing topic
            if (input.Contains("phishing"))
            {
                memory.LastTopic = "phishing";

                return AddSentiment(sentiment)
                    + responseManager.GetRandomResponse("phishing");
            }

            // Privacy topic
            if (input.Contains("privacy"))
            {
                memory.LastTopic = "privacy";

                return AddSentiment(sentiment)
                    + responseManager.GetRandomResponse("privacy");
            }

            // Scam topic
            if (input.Contains("scam"))
            {
                memory.LastTopic = "scam";

                return AddSentiment(sentiment)
                    + responseManager.GetRandomResponse("scam");
            }

            // Safe browsing topic
            if (input.Contains("browsing"))
            {
                return "Use HTTPS websites and avoid suspicious downloads.";
            }

            // Greeting
            if (input.Contains("hello") || input.Contains("hi"))
            {
                return "Hello. How can I help you today?";
            }

            // Purpose
            if (input.Contains("purpose"))
            {
                return "My purpose is to educate users about cybersecurity.";
            }

            // Unknown input
            return "I'm not sure I understand. Can you try rephrasing?";
        }

        // Adds emotion-aware responses
        private string AddSentiment(string sentiment)
        {
            if (sentiment == "worried")
            {
                return "It is understandable to feel worried. ";
            }

            if (sentiment == "frustrated")
            {
                return "I understand this can feel frustrating. ";
            }

            if (sentiment == "curious")
            {
                return "That is a great topic to learn about. ";
            }

            return "";
        }
    }
}
