namespace CyberSecurityChatbotGUI
{
    public class ToneAnalyzer
    {
        // Detects emotion from user input
        public string DetectTone(string input)
        {
            input = input.ToLower();

            // Worried emotion
            if (input.Contains("worried") || input.Contains("afraid"))
            {
                return "worried";
            }

            // Frustrated emotion
            if (input.Contains("frustrated") || input.Contains("angry"))
            {
                return "frustrated";
            }

            // Curious emotion
            if (input.Contains("curious") || input.Contains("interested"))
            {
                return "curious";
            }

            // Default emotion
            return "neutral";
        }
    }
}