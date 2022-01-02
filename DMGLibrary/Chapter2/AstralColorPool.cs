namespace DMG.Chapter2;

public class AstralColorPool
{
    private readonly int _roll;
    private readonly string _plane;
    private readonly string _poolColor;

    public int Roll => _roll;
    public string Plane => _plane;
    public string PoolColor => _poolColor;

    public AstralColorPool(int roll, string plane, string poolColor)
    {
        _roll = roll;
        _plane = plane;
        _poolColor = poolColor;
    }
}
