namespace DungeonMastersGuide.Chapter3;

public class DungeonGoal
{
    private readonly int _roll;
    private readonly string _goal;

    public int Roll => _roll;
    public string Goal => _goal;

    public DungeonGoal(int roll, string goal)
    {
        _roll = roll;
        _goal = goal;
    }
}
