namespace CybersecurityAwarenessBot;

public static class ConsoleUI
{
    public static void ConfigureConsole()
    {
        Console.Title = "Cybersecurity Awareness Assistant";
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();
    }

    public static void ShowSplashScreen()
    {
        var art = """
   ╔══════════════════════════════════════════════════════════════════════╗
   ║   ██████╗██╗   ██╗██████╗ ███████╗██████╗     ███████╗ █████╗       ║
   ║  ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗    ██╔════╝██╔══██╗      ║
   ║  ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝    ███████╗███████║      ║
   ║  ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗    ╚════██║██╔══██║      ║
   ║  ╚██████╗   ██║   ██████╔╝███████╗██║  ██║    ███████║██║  ██║      ║
   ║   ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝    ╚══════╝╚═╝  ╚═╝      ║
   ║                                                                      ║
   ║            Cybersecurity Awareness Assistant for Citizens            ║
   ╚══════════════════════════════════════════════════════════════════════╝
""";

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(art);
        Console.ResetColor();

        TypeLine("Stay alert. Stay informed. Stay safe online.", ConsoleColor.Yellow);
        TypeLine("I can help with phishing, passwords, suspicious links, malware, and safe browsing.\n", ConsoleColor.Gray);
    }

    public static string PromptForName()
    {
        while (true)
        {
            WriteSectionHeader("Welcome");
            TypeLine("What is your name?", ConsoleColor.Green);
            WritePrompt("> ");

            string? input = Console.ReadLine()?.Trim();

            if (!string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine();
                TypeLine($"Nice to meet you, {input}!", ConsoleColor.Green);
                return input;
            }

            TypeLine("Please enter a valid name so I can personalise the chat.", ConsoleColor.Red);
            Console.WriteLine();
        }
    }

    public static void ShowIntro(string userName)
    {
        WriteSectionHeader("Main Menu");
        TypeLine($"Hello {userName}! Ask me a cybersecurity question or choose one of these topics:", ConsoleColor.Cyan);
        Console.WriteLine("  • phishing");
        Console.WriteLine("  • passwords");
        Console.WriteLine("  • suspicious links");
        Console.WriteLine("  • malware");
        Console.WriteLine("  • safe browsing");
        Console.WriteLine("  • privacy");
        Console.WriteLine("  • social engineering");
        Console.WriteLine("  • help");
        Console.WriteLine("  • exit");
        Console.WriteLine();
    }

    public static void WriteSectionHeader(string title)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(new string('═', 72));
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($" {title.ToUpperInvariant()}");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(new string('═', 72));
        Console.ResetColor();
    }

    public static void WritePrompt(string text)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(text);
        Console.ResetColor();
    }

    public static void WriteBotMessage(string title, string message, ConsoleColor colour = ConsoleColor.White)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("\n┌──────────────────────────────── BOT RESPONSE ───────────────────────────────┐");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"  {title}");
        Console.ResetColor();
        Console.WriteLine();

        TypeWrappedText(message, colour);

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────┘\n");
        Console.ResetColor();
    }

    public static void ShowGoodbye(string userName)
    {
        WriteSectionHeader("Goodbye");
        TypeLine($"Goodbye, {userName}. Remember: think before you click, verify before you trust.", ConsoleColor.Magenta);
        TypeLine("Thank you for using the Cybersecurity Awareness Assistant.", ConsoleColor.Gray);
    }

    public static void TypeLine(string text, ConsoleColor colour = ConsoleColor.White, int delayMs = 8)
    {
        Console.ForegroundColor = colour;

        foreach (char character in text)
        {
            Console.Write(character);
            Thread.Sleep(delayMs);
        }

        Console.WriteLine();
        Console.ResetColor();
    }

    public static void TypeWrappedText(string text, ConsoleColor colour = ConsoleColor.White)
    {
        Console.ForegroundColor = colour;

        foreach (string paragraph in text.Split("\n\n"))
        {
            foreach (string rawLine in paragraph.Split('\n'))
            {
                foreach (string line in WrapText(rawLine.Trim(), 70))
                {
                    Console.WriteLine($"  {line}");
                    Thread.Sleep(5);
                }
            }

            Console.WriteLine();
        }

        Console.ResetColor();
    }

    private static IEnumerable<string> WrapText(string text, int maxLineLength)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            yield return string.Empty;
            yield break;
        }

        var words = text
            .Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

        var currentLine = words[0];

        for (int i = 1; i < words.Length; i++)
        {
            string nextWord = words[i];

            if ($"{currentLine} {nextWord}".Length <= maxLineLength)
            {
                currentLine += $" {nextWord}";
            }
            else
            {
                yield return currentLine;
                currentLine = nextWord;
            }
        }

        yield return currentLine;
    }
}
