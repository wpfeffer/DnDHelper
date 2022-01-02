namespace DMG.Chapter2;

public class EtherealCurtain
{
    private readonly int _roll;
    private readonly string _plane;
    private readonly string _color;

    public int Roll => _roll;
    public string Plane => _plane;
    public string Color => _color;

    public EtherealCurtain(int roll, string plane, string color)
    {
        _roll = roll;
        _plane = plane;
        _color = color;
    }
}
