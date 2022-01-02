namespace DMG.Chapter2;

public static class EtherealCurtains
{
    public static List<EtherealCurtain> Curtains = new();

    static EtherealCurtains()
    {
        Curtains.Add(new EtherealCurtain(0, string.Empty, string.Empty));
        Curtains.Add(new EtherealCurtain(1, "Material Plane", "Bright turquoise"));
        Curtains.Add(new EtherealCurtain(2, "Shadowfell", "Dusky gray"));
        Curtains.Add(new EtherealCurtain(3, "Feywild", "Opalescent white"));
        Curtains.Add(new EtherealCurtain(4, "Plane of Air", "Pale blue"));
        Curtains.Add(new EtherealCurtain(5, "Plane of Earth", "Reddish-brown"));
        Curtains.Add(new EtherealCurtain(6, "Plane of Fire", "Orange"));
        Curtains.Add(new EtherealCurtain(7, "Plane of Water", "Green"));
        Curtains.Add(new EtherealCurtain(8, "Elemental Chaos", "Swirling mix of colors"));
    }
}
