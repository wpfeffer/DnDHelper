namespace DungeonMastersGuide.Chapter1
{
    public class Discovery
    {
        private readonly int _roll;
        private readonly string _discovery;

        public int Roll => _roll;
        public string _Discovery => _discovery;

        public Discovery(int roll, string discovery)
        {
            _roll = roll;
            _discovery = discovery;
        }
    }
}