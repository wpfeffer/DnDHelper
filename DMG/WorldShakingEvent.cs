namespace DMG
{
    public class WorldShakingEvent
    {
        public int Roll { get; set; }
        public string Event { get; set; }

        public WorldShakingEvent()
        {
            Roll = 0;
            Event = string.Empty;
        }

        public WorldShakingEvent(int roll, string _event)
        {
            Roll = roll;
            Event = _event;
        }
    }
}
