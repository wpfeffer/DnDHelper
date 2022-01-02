namespace DMG.Chapter3;

public static class AdventurePatrons
{
    public static List<AdventurePatron> Patrons = new();

    static AdventurePatrons()
    {
        Patrons.Add(new AdventurePatron(0, string.Empty));
        Patrons.Add(new AdventurePatron(1, "Retired adventurer"));
        Patrons.Add(new AdventurePatron(2, "Retired adventurer"));
        Patrons.Add(new AdventurePatron(3, "Local ruler"));
        Patrons.Add(new AdventurePatron(4, "Local ruler"));
        Patrons.Add(new AdventurePatron(5, "Military officer"));
        Patrons.Add(new AdventurePatron(6, "Military officer"));
        Patrons.Add(new AdventurePatron(7, "Temple official"));
        Patrons.Add(new AdventurePatron(8, "Temple official"));
        Patrons.Add(new AdventurePatron(9, "Sage"));
        Patrons.Add(new AdventurePatron(10, "Sage"));
        Patrons.Add(new AdventurePatron(11, "Respected elder"));
        Patrons.Add(new AdventurePatron(12, "Respected elder"));
        Patrons.Add(new AdventurePatron(13, "Deity or celestial"));
        Patrons.Add(new AdventurePatron(14, "Mysterious Fey"));
        Patrons.Add(new AdventurePatron(15, "Old friend"));
        Patrons.Add(new AdventurePatron(16, "Former teacher"));
        Patrons.Add(new AdventurePatron(17, "Parent or other family member"));
        Patrons.Add(new AdventurePatron(18, "Desperate commoner"));
        Patrons.Add(new AdventurePatron(19, "Embattled merchant"));
        Patrons.Add(new AdventurePatron(20, "Villain posing as a patron"));
    }
}
