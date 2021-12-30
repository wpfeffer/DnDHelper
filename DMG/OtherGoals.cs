namespace DMG;

public static class OtherGoals
{
    public static List<OtherGoal> Goals = new();

    static OtherGoals()
    {
        Goals.Add(new OtherGoal(0, string.Empty));
        Goals.Add(new OtherGoal(1, "Seize control of a fortified location such as a fortress, town, or ship."));
        Goals.Add(new OtherGoal(2, "Defend a location from attackers."));
        Goals.Add(new OtherGoal(3, "Retrieve an object from inside a secure location in a settlement."));
        Goals.Add(new OtherGoal(4, "Retrieve an object from a caravan."));
        Goals.Add(new OtherGoal(5, "Salvage an object or goods from a lost vessel or caravan."));
        Goals.Add(new OtherGoal(6, "Break a prisoner out of a jail or prison camp."));
        Goals.Add(new OtherGoal(7, "Escape from a jail or prison camp."));
        Goals.Add(new OtherGoal(8, "Successfully travel through an obstacle course to gain recognition or reward."));
        Goals.Add(new OtherGoal(9, "Infiltrate a fortified location."));
        Goals.Add(new OtherGoal(10, "Find the source of strange occurrences in a haunted house or other location."));
        Goals.Add(new OtherGoal(11, "Interfere with operation of a business."));
        Goals.Add(new OtherGoal(12, "Rescue a character, monster, or object from a natural or unnatural disaster."));
    }
}