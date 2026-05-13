namespace CyberSecurityChatbot
{
    // Delegate used to process chatbot responses
    public delegate string ResponseDelegate(string input);

    public class Chatbot
    {
        // Handles explanations and random tips
        private ResponseManager responseManager = new ResponseManager();

        // Stores remembered user information
        private MemoryManager memory = new MemoryManager();

        // Detects user mood
        private ToneAnalyzer toneAnalyzer = new ToneAnalyzer();

        // Main response method
        public string GetResponse(string input)
        {
            // Uses delegate to process input
            ResponseDelegate responseHandler = ProcessInput;

            return responseHandler(input);
        }

        // Processes user input
        private string ProcessInput(string input)
        {
            // Handles empty input
            if (string.IsNullOrWhiteSpace(input))
            {
                return "Please enter a message.";
            }

            // Converts input to lowercase
            input = input.ToLower();

            // Detects tone
            string tone = toneAnalyzer.DetectTone(input);

            // Stores user name
            if (input.Contains("my name is"))
            {
                memory.UserName = input.Replace("my name is", "").Trim();

                return "Nice to meet you, " + memory.UserName + ". I will remember your name.";
            }

            // Stores favourite topic
            if (input.Contains("interested in"))
            {
                memory.FavouriteTopic =
                    input.Replace("i am interested in", "")
                         .Replace("interested in", "")
                         .Trim();

                memory.LastTopic = memory.FavouriteTopic;

                return "Great. I will remember that you are interested in " + memory.FavouriteTopic + ".";
            }

            // Recalls stored memory
            if (input.Contains("remember") ||
                input.Contains("what do you know about me"))
            {
                if (memory.UserName != "" && memory.FavouriteTopic != "")
                {
                    return "I remember that your name is " + memory.UserName +
                           " and you are interested in " + memory.FavouriteTopic + ".";
                }

                if (memory.UserName != "")
                {
                    return "I remember that your name is " + memory.UserName + ".";
                }

                if (memory.FavouriteTopic != "")
                {
                    return "I remember that you are interested in " + memory.FavouriteTopic + ".";
                }

                return "I do not have any saved details about you yet.";
            }

            // Detects topic
            string topic = DetectTopic(input);

            // Randomises only when the user asks for tips or another tip
            if (IsTipRequest(input))
            {
                if (topic != "")
                {
                    memory.LastTopic = topic;

                    return AddTone(tone) +
                           responseManager.GetRandomTip(topic);
                }

                if (memory.LastTopic != "")
                {
                    return responseManager.GetRandomTip(memory.LastTopic);
                }

                return "Which topic do you want tips about? You can ask for password tips, phishing tips, scam tips, privacy tips, safe browsing tips, malware tips, or 2FA tips.";
            }

            // Gives fixed explanation for direct topic questions
            if (topic != "")
            {
                memory.LastTopic = topic;

                return AddTone(tone) +
                       responseManager.GetExplanation(topic);
            }

            // Greeting response
            if (input.Contains("hello") ||
                input.Contains("hi") ||
                input.Contains("hey"))
            {
                return "Hello. I can help you learn about passwords, phishing, scams, privacy, safe browsing, malware, and two-factor authentication.";
            }

            // Purpose response
            if (input.Contains("purpose") ||
                input.Contains("what can you do"))
            {
                return "My purpose is to teach cybersecurity awareness by giving simple explanations, safety tips, and guidance based on your questions.";
            }

            // Help response
            if (input.Contains("help") ||
                input.Contains("topics"))
            {
                return "You can ask direct questions like 'What is phishing?' or ask for random tips like 'Give me a phishing tip'.";
            }

            // Default fallback
            return "I'm not sure I understand. Can you try asking about passwords, phishing, scams, privacy, safe browsing, malware, or 2FA?";
        }

        // Detects whether the user is asking for tips
        private bool IsTipRequest(string input)
        {
            return input.Contains("tip") ||
                   input.Contains("tips") ||
                   input.Contains("advice") ||
                   input.Contains("another") ||
                   input.Contains("suggestion") ||
                   input.Contains("recommend");
        }

        // Detects the cybersecurity topic
        private string DetectTopic(string input)
        {
            if (input.Contains("password") ||
                input.Contains("passcode"))
            {
                return "password";
            }

            if (input.Contains("phishing") ||
                input.Contains("fake email") ||
                input.Contains("suspicious email"))
            {
                return "phishing";
            }

            if (input.Contains("scam") ||
                input.Contains("fraud") ||
                input.Contains("trick"))
            {
                return "scam";
            }

            if (input.Contains("privacy") ||
                input.Contains("personal information") ||
                input.Contains("data"))
            {
                return "privacy";
            }

            if (input.Contains("browsing") ||
                input.Contains("website") ||
                input.Contains("https") ||
                input.Contains("download"))
            {
                return "browsing";
            }

            if (input.Contains("malware") ||
                input.Contains("virus") ||
                input.Contains("trojan"))
            {
                return "malware";
            }

            if (input.Contains("2fa") ||
                input.Contains("two factor") ||
                input.Contains("multi factor") ||
                input.Contains("authentication"))
            {
                return "2fa";
            }

            return "";
        }

        // Adds emotional support based on detected tone
        private string AddTone(string tone)
        {
            if (tone == "worried")
            {
                return "It is understandable to feel worried. Here is something that can help: ";
            }

            if (tone == "frustrated")
            {
                return "I understand this can feel frustrating. Let’s keep it simple: ";
            }

            if (tone == "curious")
            {
                return "That is a great topic to be curious about. ";
            }

            return "";
        }
    }
}