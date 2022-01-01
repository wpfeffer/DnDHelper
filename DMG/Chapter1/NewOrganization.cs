namespace DungeonMastersGuide.Chapter1
{
    public class NewOrganization
    {
        private readonly int _roll;
        private readonly string _organization;

        public int Roll => _roll;
        public string Organization => _organization;

        public NewOrganization(int roll, string organization)
        {
            _roll = roll;
            _organization = organization;
        }
    }
}