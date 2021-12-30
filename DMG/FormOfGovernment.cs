namespace DMG
{
    public class FormOfGovernment
    {
        public int Roll { get; set; }
        public string Government { get; set; }
        public string Description { get; set; }

        public FormOfGovernment()
        {
            Roll = 0;
            Government = string.Empty;
            Description = string.Empty;
        }

        public FormOfGovernment(int roll, string government, string description)
        {
            Roll = roll;
            Government = government;
            Description = description;
        }
    }
}
