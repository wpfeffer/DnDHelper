namespace DungeonMastersGuide.Chapter1
{
    public static class InvadingForces
    {
        public static List<InvadingForce> Forces = new List<InvadingForce>();

        static InvadingForces()
        {
            Forces.Add(new InvadingForce(0, string.Empty));
            Forces.Add(new InvadingForce(1, "A criminal enterprise"));
            Forces.Add(new InvadingForce(2, "Monsters or a unique monster"));
            Forces.Add(new InvadingForce(3, "A planar threat"));
            Forces.Add(new InvadingForce(4, "A past adversary reawakened, reborn, or resurgent"));
            Forces.Add(new InvadingForce(5, "A splinter faction"));
            Forces.Add(new InvadingForce(6, "A savage tribe"));
            Forces.Add(new InvadingForce(7, "A secret society"));
            Forces.Add(new InvadingForce(8, "A traitorous ally"));
        }
    }
}
