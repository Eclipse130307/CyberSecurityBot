namespace CyberSecurityChatbot
{
    public class MemoryManager
    {
        // Stores user name
        public string UserName { get; set; } = "";

        // Stores favourite topic
        public string FavouriteTopic { get; set; } = "";

        // Stores last discussed topic
        public string LastTopic { get; set; } = "";
    }
}