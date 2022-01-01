namespace DungeonMastersGuide.Chapter2.PsychicWindEffects;

public class LocationEffect
{
    private readonly int _roll;
    private readonly string _effect;

    public int Roll => _roll;
    public string Effect => _effect;

    public LocationEffect(int roll, string effect)
    {
        _roll = roll;
        _effect = effect;
    }
}
