namespace DMG;

public class DungeonGoal
{
    public int Roll { get; set; }
    public string Goal { get; set; }

    public DungeonGoal()
    {
        Roll = 0;
        Goal = string.Empty;
    }

    public DungeonGoal(int roll, string goal)
    {
        Roll = roll;
        Goal = goal;
    }
}