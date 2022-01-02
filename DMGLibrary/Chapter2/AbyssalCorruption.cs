namespace DMG.Chapter2;

public class AbyssalCorruption
{
    private readonly int _roll;
    private readonly string _result;

    public int Roll => _roll;
    public string Result => _result;

    public AbyssalCorruption(int roll, string result)
    {
        _roll = roll;
        _result = result;
    }
}
