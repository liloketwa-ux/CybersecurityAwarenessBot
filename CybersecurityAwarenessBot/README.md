Cybersecurity Awareness Assistant

A C# console chatbot that teaches users basic cybersecurity awareness through a friendly, interactive conversation.

 ## Features
- Voice greeting on startup using a WAV file
- ASCII art splash screen
- Personalised greeting using the user's name
- Cybersecurity responses for:
  - phishing
  - password safety
  - suspicious links
  - malware
  - safe browsing
  - privacy
  - social engineering
- Input validation for empty or unsupported entries
- Coloured console interface with section dividers
- Structured code split across multiple classes
- GitHub Actions workflow for CI

## Project Structure
```text
CybersecurityAwarenessBot/
├── Assets/
│   ├── ascii_art.txt
│   └── welcome.wav
├── .github/
│   └── workflows/
│       └── dotnet.yml
├── AudioPlayer.cs
├── Chatbot.cs
├── ConsoleUI.cs
├── KnowledgeBase.cs
├── Program.cs
├── CybersecurityAwarenessBot.csproj
└── README.md
```

## How to Run
1. Open the project in Visual Studio or VS Code with the C# extension.
2. Restore NuGet packages.
3. Build the solution.
4. Run the console application.
5. Type your name and start asking cybersecurity questions.

## Important Submission Notes
- Replace `Assets/welcome.wav` with your own recorded voice greeting before final submission.
- Push the full project to GitHub.
- Make at least six meaningful commits.
- Ensure your GitHub Actions workflow shows a successful green check.
- Add a screenshot of the successful CI run into this README before submission.
- Submit your unlisted YouTube presentation link separately as required.

## Suggested Commit Messages
1. Initial commit: Set up project structure and core files
2. Added ASCII splash screen and console styling
3. Implemented voice greeting playback
4. Added personalised greeting and user interaction
5. Implemented cybersecurity knowledge base and input validation
6. Added GitHub Actions workflow and updated README
