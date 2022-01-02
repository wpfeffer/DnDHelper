namespace DMG.Chapter3;

public class OtherGoal
{
    private readonly int _roll;
    private readonly string _goal;

    public int Roll => _roll;

    public string Goal => _goal;

    public OtherGoal(int roll, string goal)
    {
        _roll = roll;
        _goal = goal;
    }
}
