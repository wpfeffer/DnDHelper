namespace DMG;

public class WildernessGoal
{
    public int Roll { get; set; }
    public string Goal { get; set; }

    public WildernessGoal()
    {
        Roll = 0;
        Goal = string.Empty;
    }

    public WildernessGoal(int roll, string goal)
    {
        Roll = roll;
        Goal = goal;
    }
}