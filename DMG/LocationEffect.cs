namespace DMG.PsychicWindEffects
{
    public class LocationEffect
    {
        public int Roll { get; set; }
        public string Effect { get; set; }

        public LocationEffect()
        {
            Roll = 0;
            Effect = string.Empty;
        }

        public LocationEffect(int roll, string effect)
        {
            Roll = roll;
            Effect = effect;
        }
    }
}