namespace DMG;

public class FeywildTimeWarp
{
    public int Roll { get; set; }
    public string Result { get; set; }

    public FeywildTimeWarp()
    {
        Roll = 0;
        Result = string.Empty;
    }

    public FeywildTimeWarp(int roll, string result)
    {
        Roll = roll;
        Result = result;
    }
}