namespace DungeonMastersGuide.Chapter2;

public static class FeywildTimeWarps
{
    public static List<FeywildTimeWarp> TimeWarps = new();

    static FeywildTimeWarps()
    {
        TimeWarps.Add(new FeywildTimeWarp(0, string.Empty));
        TimeWarps.Add(new FeywildTimeWarp(1, "Days become minutes"));
        TimeWarps.Add(new FeywildTimeWarp(2, "Days become minutes"));
        TimeWarps.Add(new FeywildTimeWarp(3, "Days become hours"));
        TimeWarps.Add(new FeywildTimeWarp(4, "Days become hours"));
        TimeWarps.Add(new FeywildTimeWarp(5, "Days become hours"));
        TimeWarps.Add(new FeywildTimeWarp(6, "Days become hours"));
        TimeWarps.Add(new FeywildTimeWarp(7, "No change"));
        TimeWarps.Add(new FeywildTimeWarp(8, "No change"));
        TimeWarps.Add(new FeywildTimeWarp(9, "No change"));
        TimeWarps.Add(new FeywildTimeWarp(10, "No change"));
        TimeWarps.Add(new FeywildTimeWarp(11, "No change"));
        TimeWarps.Add(new FeywildTimeWarp(12, "No change"));
        TimeWarps.Add(new FeywildTimeWarp(13, "No change"));
        TimeWarps.Add(new FeywildTimeWarp(14, "Days become weeks"));
        TimeWarps.Add(new FeywildTimeWarp(15, "Days become weeks"));
        TimeWarps.Add(new FeywildTimeWarp(16, "Days become weeks"));
        TimeWarps.Add(new FeywildTimeWarp(17, "Days become weeks"));
        TimeWarps.Add(new FeywildTimeWarp(18, "Days become months"));
        TimeWarps.Add(new FeywildTimeWarp(19, "Days become months"));

    }
}
