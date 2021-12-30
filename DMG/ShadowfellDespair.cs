namespace DMG;

public class ShadowfellDespair
{
    private readonly int _roll;
    private readonly string _effect;

    public int Roll => _roll;
    public string Effect => _effect;

    public ShadowfellDespair(int roll, string effect)
    {
        _roll = roll;
        _effect = effect;
    }
}