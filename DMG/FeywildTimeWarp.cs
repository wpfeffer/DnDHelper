namespace DungeonMastersGuide
{
    public class FeywildTimeWarp
    {
        private readonly int _roll;
        private readonly string _result;

        public int Roll => _roll;
        public string Result => _result;

        public FeywildTimeWarp(int roll, string result)
        {
            _roll = roll;
            _result = result;
        }
    }
}