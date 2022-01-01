namespace DungeonMastersGuide.Chapter3;

public static class AdventureVillains
{
    public static List<AdventureVillain> Villains = new();

    static AdventureVillains()
    {
        Villains.Add(new AdventureVillain(0, string.Empty));
        Villains.Add(new AdventureVillain(1, "Beast or monstrosity with no particular agenda"));
        Villains.Add(new AdventureVillain(2, "Aberration bent on corruption or domination"));
        Villains.Add(new AdventureVillain(3, "Fiend bent on corruption or destruction"));
        Villains.Add(new AdventureVillain(4, "Dragon bent on domination and plunder"));
        Villains.Add(new AdventureVillain(5, "Giant bent on plunder"));
        Villains.Add(new AdventureVillain(6, "Undead with any agenda"));
        Villains.Add(new AdventureVillain(7, "Undead with any agenda"));
        Villains.Add(new AdventureVillain(8, "Fey with a mysterious goal"));
        Villains.Add(new AdventureVillain(9, "Humanoid cultist"));
        Villains.Add(new AdventureVillain(10, "Humanoid cultist"));
        Villains.Add(new AdventureVillain(11, "Humanoid conqueror"));
        Villains.Add(new AdventureVillain(12, "Humanoid conqueror"));
        Villains.Add(new AdventureVillain(13, "Huamoid seeking revenge"));
        Villains.Add(new AdventureVillain(14, "Humanoid schemer seeking to rule"));
        Villains.Add(new AdventureVillain(15, "Humanoid schemer seeking to rule"));
        Villains.Add(new AdventureVillain(16, "Humanoid criminal mastermind"));
        Villains.Add(new AdventureVillain(17, "Humanoid raider or ravager"));
        Villains.Add(new AdventureVillain(18, "Humanoid raider or ravager"));
        Villains.Add(new AdventureVillain(19, "Humanoid under a curse"));
        Villains.Add(new AdventureVillain(20, "Misguided humanoid zealot"));
    }
}
