using System.Media;

namespace CybersecurityAwarenessBot;

public static class AudioPlayer
{
    public static void TryPlayGreeting(string wavPath)
    {
        try
        {
            if (!File.Exists(wavPath))
            {
                return;
            }

            using var player = new SoundPlayer(wavPath);
            player.PlaySync();
        }
        catch
        {
            // If the audio cannot play on the current machine, the chatbot should still continue.
        }
    }
}
