namespace DMG.Chapter1;

public class InvadingForce
{
    private readonly int _roll;
    private readonly string _force;

    public int Roll => _roll;
    public string Force => _force;

    public InvadingForce(int roll, string force)
    {
        _roll = roll;
        _force = force;
    }
}
