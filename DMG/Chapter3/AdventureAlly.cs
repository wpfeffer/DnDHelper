namespace DungeonMastersGuide.Chapter3;

public class AdventureAlly
{
    private readonly int _roll;
    private readonly string _ally;

    public int Roll => _roll;

    public string Ally => _ally;

    public AdventureAlly(int roll, string ally)
    {
        _roll = roll;
        _ally = ally;
    }
}
