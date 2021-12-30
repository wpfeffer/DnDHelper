namespace DMG;

public class EtherealCurtain
{
    public int Roll { get; set; }
    public string Plane { get; set; }
    public string Color { get; set; }

    public EtherealCurtain()
    {
        Roll = 0;
        Plane = string.Empty;
        Color = string.Empty;
    }

    public EtherealCurtain(int roll, string plane, string color)
    {
        Roll = roll;
        Plane = plane;
        Color = color;
    }
}