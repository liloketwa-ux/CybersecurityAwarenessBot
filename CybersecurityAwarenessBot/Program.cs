using CybersecurityAwarenessBot;

ConsoleUI.ConfigureConsole();
AudioPlayer.TryPlayGreeting(Path.Combine(AppContext.BaseDirectory, "Assets", "welcome.wav"));
ConsoleUI.ShowSplashScreen();

string userName = ConsoleUI.PromptForName();

var chatbot = new Chatbot(userName);
chatbot.RunConversation();

ConsoleUI.ShowGoodbye(userName);
