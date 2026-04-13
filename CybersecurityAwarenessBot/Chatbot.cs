namespace CybersecurityAwarenessBot;

public sealed class Chatbot
{
    private readonly string _userName;
    private readonly KnowledgeBase _knowledgeBase = new();

    public Chatbot(string userName)
    {
        _userName = userName;
    }

    public void RunConversation()
    {
        ConsoleUI.ShowIntro(_userName);

        bool keepRunning = true;

        while (keepRunning)
        {
            ConsoleUI.WritePrompt($"{_userName}> ");
            string? input = Console.ReadLine();

            ChatbotResponse response = BuildResponse(input);
            ConsoleUI.WriteBotMessage(response.Title, response.Message, response.Colour);

            keepRunning = !response.ExitRequested;
        }
    }

    private ChatbotResponse BuildResponse(string? rawInput)
    {
        if (string.IsNullOrWhiteSpace(rawInput))
        {
            return new ChatbotResponse(
                "Input Validation",
                "I did not receive a valid question. Please type something like phishing, passwords, suspicious links, or safe browsing.",
                ConsoleColor.Red);
        }

        string input = rawInput.Trim().ToLowerInvariant();

        if (IsExitCommand(input))
        {
            return new ChatbotResponse(
                "Session Ending",
                $"Thanks for chatting with me, {_userName}. Keep practicing safe online behaviour.",
                ConsoleColor.Magenta,
                true);
        }

        string? knowledgeResponse = _knowledgeBase.FindResponse(input);

        if (!string.IsNullOrWhiteSpace(knowledgeResponse))
        {
            return new ChatbotResponse("Cybersecurity Guidance", $"{_userName}, {knowledgeResponse}", ConsoleColor.White);
        }

        return new ChatbotResponse(
            "Unknown Request",
            $"{_userName}, I did not quite understand that. Could you rephrase? Try asking about phishing, passwords, suspicious links, malware, privacy, or safe browsing.",
            ConsoleColor.Yellow);
    }

    private static bool IsExitCommand(string input)
    {
        return input is "exit" or "quit" or "bye" or "close";
    }
}

public sealed record ChatbotResponse(
    string Title,
    string Message,
    ConsoleColor Colour,
    bool ExitRequested = false);
