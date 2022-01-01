namespace DungeonMastersGuide.Chapter1;

public static class LeaderTypes
{
    public static List<LeaderType> Types = new();

    static LeaderTypes()
    {
        Types.Add(new LeaderType(0, string.Empty));
        Types.Add(new LeaderType(1, "Political"));
        Types.Add(new LeaderType(2, "Religious"));
        Types.Add(new LeaderType(3, "Military"));
        Types.Add(new LeaderType(4, "Crime/Underworld"));
        Types.Add(new LeaderType(5, "Art/Culture"));
        Types.Add(new LeaderType(6, "Philosophy/Learning/Magic"));
    }
}
