namespace DungeonMastersGuide
{
    public static class WildernessGoals
    {
        public static List<WildernessGoal> Goals = new();

        static WildernessGoals()
        {
            Goals.Add(new WildernessGoal(0, string.Empty));
            Goals.Add(new WildernessGoal(1, "Locate a dungeon or other site of interest (roll on the Dungeon Goals table to find out why)."));
            Goals.Add(new WildernessGoal(2, "Assess the scope of a natural or unnatural disaster."));
            Goals.Add(new WildernessGoal(3, "Escort an NPC to a destination."));
            Goals.Add(new WildernessGoal(4, "Arrive at a destination without being seen by the villain's forces."));
            Goals.Add(new WildernessGoal(5, "Stop monsters from raiding caravans and farms."));
            Goals.Add(new WildernessGoal(6, "Establish trade with a distant town."));
            Goals.Add(new WildernessGoal(7, "Protect a caravan traveling to a distant town."));
            Goals.Add(new WildernessGoal(8, "Map a new land."));
            Goals.Add(new WildernessGoal(9, "Find a place to establish a colony."));
            Goals.Add(new WildernessGoal(10, "Find a natural resource."));
            Goals.Add(new WildernessGoal(11, "Hunt a specific monster."));
            Goals.Add(new WildernessGoal(12, "Return home from a distant place."));
            Goals.Add(new WildernessGoal(13, "Obtain information from a reclusive hermit."));
            Goals.Add(new WildernessGoal(14, "Find an object that was lost in the wilds."));
            Goals.Add(new WildernessGoal(15, "Discover the fate of a missing group of explorers."));
            Goals.Add(new WildernessGoal(16, "Pursue fleeing foes."));
            Goals.Add(new WildernessGoal(17, "Assess the size of an approaching army."));
            Goals.Add(new WildernessGoal(18, "Escape the re3ign of a tyrant."));
            Goals.Add(new WildernessGoal(19, "Protect a wilderness site from attackers."));
            Goals.Add(new WildernessGoal(20, "Roll twice, ignoring results of 20."));
        }
    }
}