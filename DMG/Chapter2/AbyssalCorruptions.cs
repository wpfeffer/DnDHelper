namespace DungeonMastersGuide.Chapter2
{
    public static class AbyssalCorruptions
    {
        public static List<AbyssalCorruption> Corruptions = new();

        static AbyssalCorruptions()
        {
            Corruptions.Add(new AbyssalCorruption(0, string.Empty));
            Corruptions.Add(new AbyssalCorruption(1, "Treachery. The character gains the following flaw: \"I can only achieve my goals by making sure that my companions don't achieve theirs.\""));
            Corruptions.Add(new AbyssalCorruption(2, "Treachery. The character gains the following flaw: \"I can only achieve my goals by making sure that my companions don't achieve theirs.\""));
            Corruptions.Add(new AbyssalCorruption(3, "Treachery. The character gains the following flaw: \"I can only achieve my goals by making sure that my companions don't achieve theirs.\""));
            Corruptions.Add(new AbyssalCorruption(4, "Treachery. The character gains the following flaw: \"I can only achieve my goals by making sure that my companions don't achieve theirs.\""));
            Corruptions.Add(new AbyssalCorruption(5, "Bloodlust. The character gains the following flaw: \"I enjoy killing for its own sake, and once I start, it's hard to stop.\""));
            Corruptions.Add(new AbyssalCorruption(6, "Bloodlust. The character gains the following flaw: \"I enjoy killing for its own sake, and once I start, it's hard to stop.\""));
            Corruptions.Add(new AbyssalCorruption(7, "Bloodlust. The character gains the following flaw: \"I enjoy killing for its own sake, and once I start, it's hard to stop.\""));
            Corruptions.Add(new AbyssalCorruption(8, "Mad Ambition. The character gains the following flaw: \"I am destined to rule the Abyss, and my companions are tools to that end.\""));
            Corruptions.Add(new AbyssalCorruption(9, "Mad Ambition. The character gains the following flaw: \"I am destined to rule the Abyss, and my companions are tools to that end.\""));
            Corruptions.Add(new AbyssalCorruption(10, "Demonic Possession. The character is possessed by a demonic entity until freed by Dispel Evil and Good or similar magic. Whenever the possessed character rolls a 1 on an attack roll, ability check, or saving throw, the demon takes control of the character and determines the character's behavior. At the end of each of the possessed character's turns, he or she can make a DC 15 Charisma saving throw. On a success, the character regains control until he or she rolls another 1."));
        }
    }
}
