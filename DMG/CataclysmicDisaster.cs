namespace DMG
{
    public class CataclysmicDisaster
    {
        public int Roll { get; set; }
        public string Disaster { get; set; }

        public CataclysmicDisaster()
        {
            Roll = 0;
            Disaster = string.Empty;
        }

        public CataclysmicDisaster(int roll, string disaster)
        {
            Roll = roll;
            Disaster = disaster;
        }
    }
}
