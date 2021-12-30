namespace DMG;

public class EtherCyclone
{
    private readonly int _roll;
    private readonly string _effect;

    public int Roll => _roll;
    public string Effect => _effect;

    public EtherCyclone(int roll, string effect)
    {
        _roll = roll;
        _effect = effect;
    }
}