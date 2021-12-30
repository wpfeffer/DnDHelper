namespace DMG;

public class Discovery
{
    public int Roll { get; set; }
    public string _Discovery { get; set; }

    public Discovery()
    {
        Roll = 0;
        _Discovery = string.Empty;
    }

    public Discovery(int roll, string discovery)
    {
        Roll = roll;
        _Discovery = discovery;
    }
}