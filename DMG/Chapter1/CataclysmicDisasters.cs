namespace DungeonMastersGuide.Chapter1;

public static class CataclysmicDisasters
{
    public static List<CataclysmicDisaster> Disasters = new List<CataclysmicDisaster>();

    static CataclysmicDisasters()
    {
        Disasters.Add(new CataclysmicDisaster(0, string.Empty));
        Disasters.Add(new CataclysmicDisaster(1, "Earthquake"));
        Disasters.Add(new CataclysmicDisaster(2, "Famine/drought"));
        Disasters.Add(new CataclysmicDisaster(3, "Fire"));
        Disasters.Add(new CataclysmicDisaster(4, "Flood"));
        Disasters.Add(new CataclysmicDisaster(5, "Plague/disease"));
        Disasters.Add(new CataclysmicDisaster(6, "Rain of fire (meteoric impact)"));
        Disasters.Add(new CataclysmicDisaster(7, "Storm (hurricane, tornado, tsunami)"));
        Disasters.Add(new CataclysmicDisaster(8, "Volcanic eruption"));
        Disasters.Add(new CataclysmicDisaster(9, "Magic gone awry or a planar warp"));
        Disasters.Add(new CataclysmicDisaster(10, "Divine judgement"));
    }
}
