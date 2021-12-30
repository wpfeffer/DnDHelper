namespace DMG;

public class ExtinctionOrDepletion
{
    public int Roll { get; set; }
    public string ExtinctionDepletion { get; set; }

    public ExtinctionOrDepletion()
    {
        Roll = 0;
        ExtinctionDepletion = string.Empty;
    }

    public ExtinctionOrDepletion(int roll, string extinctionDepletion)
    {
        Roll = roll;
        ExtinctionDepletion = extinctionDepletion;
    }
}