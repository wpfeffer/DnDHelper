namespace DungeonMastersGuide.Chapter1;

public class CataclysmicDisaster
{
    private readonly int _roll;
    private readonly string _disaster;

    public int Roll => _roll;
    public string Disaster => _disaster;

    public CataclysmicDisaster(int roll, string disaster)
    {
        _roll = roll;
        _disaster = disaster;
    }
}
