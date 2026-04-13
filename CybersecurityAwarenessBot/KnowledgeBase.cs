namespace CybersecurityAwarenessBot;

public sealed class KnowledgeBase
{
    public string? FindResponse(string input)
    {
        if (ContainsAny(input, "hello", "hi", "hey", "good morning", "good afternoon"))
        {
            return "Hello! I am ready to help you stay safer online.";
        }

        if (ContainsAny(input, "how are you"))
        {
            return "I am functioning well and ready to help you learn about cybersecurity.";
        }

        if (ContainsAny(input, "purpose", "what do you do", "who are you"))
        {
            return "I am a Cybersecurity Awareness Assistant. My purpose is to teach you about phishing, password safety, suspicious links, malware, privacy, and safer browsing habits.";
        }

        if (ContainsAny(input, "help", "what can i ask", "topics", "menu"))
        {
            return "You can ask me about phishing, strong passwords, suspicious links, malware, social engineering, privacy, and safe browsing. You can also type exit when you want to close the chatbot.";
        }

        if (ContainsAny(input, "password", "passphrase", "2fa", "two-factor", "multi-factor", "mfa"))
        {
            return """
Strong password safety tips:

• Use long passwords or passphrases with a mix of words.
• Avoid personal details such as birthdays or names.
• Do not reuse the same password across many accounts.
• Turn on two-factor authentication whenever possible.
• Use a trusted password manager to store strong unique passwords.
""";
        }

        if (ContainsAny(input, "phishing", "scam email", "fake email", "email scam"))
        {
            return """
Phishing is when criminals pretend to be trusted organisations to steal information.

Warning signs:
• urgent messages that pressure you to act quickly
• fake links or strange email addresses
• requests for passwords, OTPs, or banking details
• suspicious attachments

Best action:
Do not click immediately. Verify the sender, inspect the email address carefully, and contact the company through an official channel.
""";
        }

        if (ContainsAny(input, "link", "url", "website", "suspicious link", "shortened link"))
        {
            return """
Before clicking a link:

• Hover over it and inspect the full web address.
• Look for misspellings in the domain name.
• Avoid shortened or unfamiliar links from strangers.
• Check for HTTPS, but remember HTTPS alone does not guarantee safety.
• When unsure, type the official website address manually into your browser.
""";
        }

        if (ContainsAny(input, "malware", "virus", "trojan", "ransomware"))
        {
            return """
Malware is harmful software that can damage devices, spy on you, or lock your files.

To reduce the risk:
• keep your operating system and apps updated
• install software only from trusted sources
• scan attachments before opening them
• use antivirus or endpoint protection
• back up important files regularly
""";
        }

        if (ContainsAny(input, "safe browsing", "browsing", "browser", "online safety"))
        {
            return """
Safe browsing habits include:

• keeping your browser updated
• avoiding downloads from unknown sites
• logging out of shared devices
• reviewing privacy and security settings
• avoiding public Wi-Fi for sensitive banking unless you use a trusted VPN
""";
        }

        if (ContainsAny(input, "social engineering", "manipulate", "pretend", "impersonation"))
        {
            return """
Social engineering happens when attackers manipulate people instead of attacking technology directly.

Examples include:
• pretending to be technical support
• claiming there is an urgent account problem
• asking for secret information over phone, email, or chat

Rule to remember:
Pause, verify identity, and never share sensitive details under pressure.
""";
        }

        if (ContainsAny(input, "privacy", "personal information", "oversharing", "data"))
        {
            return """
Protect your privacy by sharing less personal information online.

Good habits:
• limit what you post publicly
• review app permissions
• avoid sharing ID numbers, banking details, or one-time pins
• use privacy settings on social media
• be cautious when strangers ask personal questions
""";
        }

        if (ContainsAny(input, "tip", "advice", "stay safe"))
        {
            return "A simple rule is: stop, think, and verify. Most cyber scams succeed because people are rushed, distracted, or pressured.";
        }

        return null;
    }

    private static bool ContainsAny(string input, params string[] keywords)
    {
        return keywords.Any(input.Contains);
    }
}
