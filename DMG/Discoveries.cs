namespace DMG;

public static class Discoveries
{
    public static List<Discovery> _Discoveries = new();

    static Discoveries()
    {
        _Discoveries.Add(new Discovery(0, string.Empty));
        _Discoveries.Add(new Discovery(1, "Ancient ruin/lost city of a legendary race"));
        _Discoveries.Add(new Discovery(2, "Animal/monster/magical mutation"));
        _Discoveries.Add(new Discovery(3, "Invention/technology/magic (helpful, destructive)"));
        _Discoveries.Add(new Discovery(4, "New (or forgotten) god or planar entity"));
        _Discoveries.Add(new Discovery(5, "New (or rediscovered) artifact or religious relic"));
        _Discoveries.Add(new Discovery(6, "New land (island, continent, lost world, demiplane)"));
        _Discoveries.Add(new Discovery(7, "Otherworldly object (planar portal, alien spacecraft)"));
        _Discoveries.Add(new Discovery(8, "People (race, tribe, lost civilization, colony)"));
        _Discoveries.Add(new Discovery(9, "Plant (miracle herb, fungal parasite, sentient plant)"));
        _Discoveries.Add(new Discovery(10, "Resource or wealth (gold, gems, mithral)"));
    }
}