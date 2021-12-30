namespace DMG;

public class AstralColorPool
{
    public int Roll { get; set; }
    public string Plane { get; set; }
    public string PoolColor { get; set; }

    public AstralColorPool()
    {
        Roll = 0;
        Plane = string.Empty;
        PoolColor = string.Empty;
    }

    public AstralColorPool(int roll, string plane, string poolColor)
    {
        Roll = roll;
        Plane = plane;
        PoolColor = poolColor;
    }
}