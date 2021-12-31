namespace DungeonMastersGuide
{
    public static class DungeonGoals
    {
        public static List<DungeonGoal> Goals = new();

        static DungeonGoals()
        {
            Goals.Add(new DungeonGoal(0, string.Empty));
            Goals.Add(new DungeonGoal(1, "Stop the dungeon's monstrous inhabitants from raiding the surface world."));
            Goals.Add(new DungeonGoal(2, "Foil a villain's evil scheme."));
            Goals.Add(new DungeonGoal(3, "Acquire treasure."));
            Goals.Add(new DungeonGoal(4, "Find a particular item for a specific purpose."));
            Goals.Add(new DungeonGoal(5, "Retrieve a stolen item hidden in the dungeon."));
            Goals.Add(new DungeonGoal(6, "Retrieve a stolen item hidden in the dungeon."));
            Goals.Add(new DungeonGoal(7, "Find information needed for a special purpose."));
            Goals.Add(new DungeonGoal(8, "Rescue a captive."));
            Goals.Add(new DungeonGoal(9, "Discover the fate a previous adventuring party."));
            Goals.Add(new DungeonGoal(10, "Find an NPC who disappeared in the area."));
            Goals.Add(new DungeonGoal(11, "Slay a dragon or some other challenging monster."));
            Goals.Add(new DungeonGoal(12, "discover the nature and origin of a strange location or phenomenon."));
            Goals.Add(new DungeonGoal(13, "Pursue fleeing foes taking taking refuge in the dungeon."));
            Goals.Add(new DungeonGoal(14, "Escape from captivity in the dungeon."));
            Goals.Add(new DungeonGoal(15, "Clear a ruin so it can be rebuilt and reoccupied."));
            Goals.Add(new DungeonGoal(16, "Discover why a villain is interested in the dungeon."));
            Goals.Add(new DungeonGoal(17, "Win a bet or complete a rite of passage by surviving in the dungeon for a certain amount of time."));
            Goals.Add(new DungeonGoal(18, "Parley with a villain in the dungeon."));
            Goals.Add(new DungeonGoal(19, "Hide from a threat outside the dungeon."));
            Goals.Add(new DungeonGoal(20, "Roll twice, ignoring results of 20."));
        }
    }
}