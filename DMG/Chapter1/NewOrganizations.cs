namespace DungeonMastersGuide.Chapter1
{
    public static class NewOrganizations
    {
        public static List<NewOrganization> Organizations = new();

        static NewOrganizations()
        {
            Organizations.Add(new NewOrganization(0, string.Empty));
            Organizations.Add(new NewOrganization(1, "Crime syndicate/bandit confederacy"));
            Organizations.Add(new NewOrganization(2, "Guild (masons, apothecaries, goldsmiths"));
            Organizations.Add(new NewOrganization(3, "Magical circle/society"));
            Organizations.Add(new NewOrganization(4, "Military/knightly order"));
            Organizations.Add(new NewOrganization(5, "New family dynasty/tribe/clan"));
            Organizations.Add(new NewOrganization(6, "Philosophy/discipline dedicated to a principle or ideal"));
            Organizations.Add(new NewOrganization(7, "Realm (village, town, duchy, kingdom)"));
            Organizations.Add(new NewOrganization(8, "Religion/sect/denomination"));
            Organizations.Add(new NewOrganization(9, "School/university"));
            Organizations.Add(new NewOrganization(10, "Secret society/cult/cabal"));
        }
    }
}