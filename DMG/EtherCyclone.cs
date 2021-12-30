namespace DMG;

public class EtherCyclone
{
    public int Roll { get; set; }
    public string Effect { get; set; }

    public EtherCyclone()
    {
        Roll = 0;
        Effect = string.Empty;
    }

    public EtherCyclone(int roll, string effect)
    {
        Roll = roll;
        Effect = effect;
    }
}