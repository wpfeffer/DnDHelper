namespace DungeonMastersGuide
{
    /// <summary>
    /// Gateways leading from the Astral Plane to other planes appear as two-dimensional pools of rippling colors, 1d6 x 10 feet in diameter.
    /// </summary>
    public class AstralColorPools
    {
        /// <summary>
        /// The list of color pools
        /// </summary>
        public static List<AstralColorPool> ColorPools = new();

        /// <summary>
        /// The static constructor to populate the AstralColorPool list.
        /// </summary>
        static AstralColorPools()
        {
            ColorPools.Add(new AstralColorPool(0, string.Empty, string.Empty));
            ColorPools.Add(new AstralColorPool(1, "Ysgard", "Indigo"));
            ColorPools.Add(new AstralColorPool(2, "Limbo", "Jet Black"));
            ColorPools.Add(new AstralColorPool(3, "Pandemonium", "Magenta"));
            ColorPools.Add(new AstralColorPool(4, "The Abyss", "Amethyst"));
            ColorPools.Add(new AstralColorPool(5, "Carceri", "Olive"));
            ColorPools.Add(new AstralColorPool(6, "Hades", "Rust"));
            ColorPools.Add(new AstralColorPool(7, "Gehenna", "Russet"));
            ColorPools.Add(new AstralColorPool(8, "The Nine Hells", "Ruby"));
            ColorPools.Add(new AstralColorPool(9, "Acheron", "Flame Red"));
            ColorPools.Add(new AstralColorPool(10, "Mechanus", "Diamond Blue"));
            ColorPools.Add(new AstralColorPool(11, "Arcadia", "Saffron"));
            ColorPools.Add(new AstralColorPool(12, "Mount Celestia", "Gold"));
            ColorPools.Add(new AstralColorPool(13, "Bytopia", "Amber"));
            ColorPools.Add(new AstralColorPool(14, "Elysium", "Orange"));
            ColorPools.Add(new AstralColorPool(15, "The Beastlands", "Emerald Green"));
            ColorPools.Add(new AstralColorPool(16, "Arborea", "Sapphire Blue"));
            ColorPools.Add(new AstralColorPool(17, "The Outlands", "Leather Brown"));
            ColorPools.Add(new AstralColorPool(18, "Ethereal Plane", "Spiraling White"));
            ColorPools.Add(new AstralColorPool(19, "Material Plane", "Silver"));
            ColorPools.Add(new AstralColorPool(20, "Material Plane", "Silver"));
        }
    }
}