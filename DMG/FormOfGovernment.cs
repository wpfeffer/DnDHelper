namespace DungeonMastersGuide
{
    public class FormOfGovernment
    {
        private readonly int _roll;
        private readonly string _government;
        private readonly string _description;

        public int Roll => _roll;
        public string Government => _government;
        public string Description => _description;

        public FormOfGovernment(int roll, string government, string description)
        {
            _roll = roll;
            _government = government;
            _description = description;
        }
    }
}
