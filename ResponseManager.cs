using System;
using System.Collections.Generic;

namespace CyberSecurityChatbot
{
    public class ResponseManager
    {
        // Generates random response selection
        private Random random = new Random();

        // Phishing responses
        private List<string> phishingTips = new List<string>()
        {
            "Avoid clicking suspicious email links.",
            "Verify sender email addresses carefully.",
            "Never share passwords through email.",
            "Scammers often create urgency to trick users."
        };

        // Password responses
        private List<string> passwordTips = new List<string>()
        {
            "Use strong passwords with symbols and numbers.",
            "Avoid using personal information in passwords.",
            "Use different passwords for different accounts.",
            "Use a password manager for secure storage."
        };

        // Privacy responses
        private List<string> privacyTips = new List<string>()
        {
            "Review your privacy settings regularly.",
            "Do not overshare personal information online.",
            "Enable two-factor authentication.",
            "Only install trusted applications."
        };

        // Scam responses
        private List<string> scamTips = new List<string>()
        {
            "Be cautious of messages promising prizes.",
            "Verify suspicious messages before responding.",
            "Do not send money to unknown people online.",
            "If it sounds too good to be true, it probably is."
        };

        // Returns random response based on topic
        public string GetRandomResponse(string topic)
        {
            if (topic == "phishing")
            {
                return GetRandomItem(phishingTips);
            }

            if (topic == "password")
            {
                return GetRandomItem(passwordTips);
            }

            if (topic == "privacy")
            {
                return GetRandomItem(privacyTips);
            }

            if (topic == "scam")
            {
                return GetRandomItem(scamTips);
            }

            return "I'm not sure I understand. Can you try rephrasing?";
        }

        // Returns random list item
        private string GetRandomItem(List<string> responses)
        {
            int index = random.Next(responses.Count);

            return responses[index];
        }
    }
}