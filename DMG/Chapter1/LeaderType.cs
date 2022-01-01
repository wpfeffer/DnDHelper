namespace DungeonMastersGuide.Chapter1;

public class LeaderType
{
    private readonly int _roll;
    private readonly string _type;

    public int Roll => _roll;

    public string Type => _type;

    public LeaderType(int roll, string type)
    {
        _roll = roll;
        _type = type;
    }
}
