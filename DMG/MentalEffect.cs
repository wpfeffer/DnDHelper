namespace DMG.PsychicWindEffects
{
    public class MentalEffect
    {
        public int Roll { get; set; }
        public string Effect { get; set; }

        public MentalEffect()
        {
            Roll = 0;
            Effect = string.Empty;
        }

        public MentalEffect(int roll, string effect)
        {
            Roll = roll;
            Effect = effect;
        }
    }
}