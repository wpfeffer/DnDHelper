namespace DungeonMastersGuide.Chapter1;

public static class ExtinctionsOrDepletions
{
    public static List<ExtinctionOrDepletion> ExtinctionsDepletions = new();

    static ExtinctionsOrDepletions()
    {
        ExtinctionsDepletions.Add(new ExtinctionOrDepletion(0, string.Empty));
        ExtinctionsDepletions.Add(new ExtinctionOrDepletion(1, "A kind of animal (insect, bird, fish, livestock)"));
        ExtinctionsDepletions.Add(new ExtinctionOrDepletion(2, "Habitable land"));
        ExtinctionsDepletions.Add(new ExtinctionOrDepletion(3, "Magic or magic-users (all magic, or specific kinds or schools of magic)"));
        ExtinctionsDepletions.Add(new ExtinctionOrDepletion(4, "A mineral resource (gems, metals, ores)"));
        ExtinctionsDepletions.Add(new ExtinctionOrDepletion(5, "A type of monster (unicorn, manticore, dragon)"));
        ExtinctionsDepletions.Add(new ExtinctionOrDepletion(6, "A people (family line, clan, culture, race)"));
        ExtinctionsDepletions.Add(new ExtinctionOrDepletion(7, "A kind of plant (crop, tree, herb, forest)"));
        ExtinctionsDepletions.Add(new ExtinctionOrDepletion(8, "A waterway (river, lake, ocean)"));
    }
}
