namespace DungeonMastersGuide.Chapter1
{
    public class FormOfGovernment
    {
        private readonly int _roll;
        private readonly string _government;

        public int Roll => _roll;
        public string Government => _government;

        public FormOfGovernment(int roll, string government)
        {
            _roll = roll;
            _government = government;
        }
    }
}
