using System;
using System.Collections.Generic;

namespace CyberSecurityChatbot
{
    // Manages all fixed explanations and random tips
    public class ResponseManager
    {
        // Random object used to select different tips
        private Random random = new Random();

        // Password tips
        private List<string> passwordTips = new List<string>()
        {
            "Use at least 12 characters in your password.",
            "Use uppercase letters, lowercase letters, numbers, and symbols.",
            "Do not reuse the same password on multiple accounts.",
            "Avoid using personal details such as your name or birthday.",
            "Use a password manager to store strong passwords safely."
        };

        // Phishing tips
        private List<string> phishingTips = new List<string>()
        {
            "Check the sender’s email address carefully before clicking links.",
            "Do not open suspicious attachments from unknown senders.",
            "Be careful of messages that create panic or urgency.",
            "Never enter your password on a website unless you are sure it is official.",
            "Hover over links before clicking to check where they really go."
        };

        // Scam tips
        private List<string> scamTips = new List<string>()
        {
            "Be cautious of messages promising prizes or free money.",
            "Do not send money to people you only met online.",
            "Verify suspicious messages using official company contact details.",
            "If something sounds too good to be true, it is probably a scam."
        };

        // Privacy tips
        private List<string> privacyTips = new List<string>()
        {
            "Review your privacy settings on social media regularly.",
            "Avoid sharing your address, phone number, or daily routine online.",
            "Only allow trusted apps to access your camera, microphone, and location.",
            "Use two-factor authentication on important accounts."
        };

        // Safe browsing tips
        private List<string> browsingTips = new List<string>()
        {
            "Only download files from trusted websites.",
            "Check that websites use HTTPS before entering personal details.",
            "Avoid clicking pop-up adverts or suspicious links.",
            "Keep your browser updated to reduce security risks."
        };

        // Malware tips
        private List<string> malwareTips = new List<string>()
        {
            "Do not download files from unknown websites.",
            "Keep antivirus software updated.",
            "Do not open suspicious email attachments.",
            "Keep your operating system and apps updated."
        };

        // 2FA tips
        private List<string> twoFactorTips = new List<string>()
        {
            "Enable 2FA on email, banking, and social media accounts.",
            "Use an authenticator app where possible.",
            "Do not share 2FA codes with anyone.",
            "2FA helps protect your account even if your password is stolen."
        };

        // Returns a fixed explanation for direct questions
        public string GetExplanation(string topic)
        {
            if (topic == "phishing")
            {
                return "Phishing is a cyber attack where scammers pretend to be trusted people or companies to trick you into giving away sensitive information, such as passwords, banking details, or personal data.";
            }

            if (topic == "password")
            {
                return "Password safety means creating strong, unique passwords that are difficult for attackers to guess. A good password should be long and should not use personal information.";
            }

            if (topic == "scam")
            {
                return "An online scam is a dishonest attempt to trick someone into giving away money, personal information, or account access.";
            }

            if (topic == "privacy")
            {
                return "Online privacy means controlling what personal information you share online and limiting who can access it.";
            }

            if (topic == "browsing")
            {
                return "Safe browsing means using trusted websites, checking for HTTPS, avoiding suspicious links, and not downloading unknown files.";
            }

            if (topic == "malware")
            {
                return "Malware is harmful software designed to damage devices, steal information, spy on users, or give attackers access to a system.";
            }

            if (topic == "2fa")
            {
                return "Two-factor authentication, also called 2FA, adds an extra security step after your password, such as a code from your phone or an authenticator app.";
            }

            return "I'm not sure I understand. Can you ask about passwords, phishing, scams, privacy, safe browsing, malware, or 2FA?";
        }

        // Returns a random tip only when the user asks for tips
        public string GetRandomTip(string topic)
        {
            if (topic == "password")
            {
                return GetRandomItem(passwordTips);
            }

            if (topic == "phishing")
            {
                return GetRandomItem(phishingTips);
            }

            if (topic == "scam")
            {
                return GetRandomItem(scamTips);
            }

            if (topic == "privacy")
            {
                return GetRandomItem(privacyTips);
            }

            if (topic == "browsing")
            {
                return GetRandomItem(browsingTips);
            }

            if (topic == "malware")
            {
                return GetRandomItem(malwareTips);
            }

            if (topic == "2fa")
            {
                return GetRandomItem(twoFactorTips);
            }

            return "Please choose a topic for tips, such as passwords, phishing, scams, privacy, safe browsing, malware, or 2FA.";
        }

        // Selects one random item from a list
        private string GetRandomItem(List<string> responses)
        {
            int index = random.Next(responses.Count);
            return responses[index];
        }
    }
}