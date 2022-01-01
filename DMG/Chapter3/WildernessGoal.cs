namespace DungeonMastersGuide.Chapter3
{
    public class WildernessGoal
    {
        private readonly int _roll;
        private readonly string _goal;

        public int Roll => _roll;
        public string Goal => _goal;

        public WildernessGoal(int roll, string goal)
        {
            _roll = roll;
            _goal = goal;
        }
    }
}