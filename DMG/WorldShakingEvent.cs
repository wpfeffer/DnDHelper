namespace DungeonMastersGuide
{
    public class WorldShakingEvent
    {
        private readonly int _roll;
        private readonly string _event;

        public int Roll => _roll;
        public string Event => _event;

        public WorldShakingEvent(int roll, string __event)
        {
            _roll = roll;
            _event = __event;
        }
    }
}
