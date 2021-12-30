namespace DMG;

public class ShadowfellDespair
{
    public int Roll { get; set; }
    public string Effect { get; set; }

    public ShadowfellDespair()
    {
        Roll = 0;
        Effect = string.Empty;
    }

    public ShadowfellDespair(int roll, string effect)
    {
        Roll = roll;
        Effect = effect;
    }
}