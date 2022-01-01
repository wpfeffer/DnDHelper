namespace DungeonMastersGuide.Chapter1
{
    public static class WorldShakingEvents
    {
        public static List<WorldShakingEvent> Events = new();

        static WorldShakingEvents()
        {
            Events.Add(new WorldShakingEvent(0, string.Empty));
            Events.Add(new WorldShakingEvent(1, "Rise of a leader or an era"));
            Events.Add(new WorldShakingEvent(2, "Fall of a leader or an era"));
            Events.Add(new WorldShakingEvent(3, "Cataclysmic disaster"));
            Events.Add(new WorldShakingEvent(4, "Assault or invasion"));
            Events.Add(new WorldShakingEvent(5, "Rebellion, revolution, overthrow"));
            Events.Add(new WorldShakingEvent(6, "Extinction or depletion"));
            Events.Add(new WorldShakingEvent(7, "New organization"));
            Events.Add(new WorldShakingEvent(8, "Discovery, expansion, invention"));
            Events.Add(new WorldShakingEvent(9, "Prediction, omen, prophecy"));
            Events.Add(new WorldShakingEvent(10, "Myth and legend"));
        }
    }
}
