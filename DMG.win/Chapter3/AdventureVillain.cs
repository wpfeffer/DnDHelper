namespace DungeonMastersGuide.Chapter3;

public class AdventureVillain
{
    private readonly int _roll;
    private readonly string _villain;

    public int Roll => _roll;

    public string Villain => _villain;

    public AdventureVillain(int roll, string villain)
    {
        _roll = roll;
        _villain = villain;
    }
}
