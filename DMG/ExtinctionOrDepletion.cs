namespace DungeonMastersGuide
{
    public class ExtinctionOrDepletion
    {
        private readonly int _roll;
        private readonly string _extinctionDepletion;

        public int Roll => _roll;
        public string ExtinctionDepletion => _extinctionDepletion;

        public ExtinctionOrDepletion(int roll, string extinctionDepletion)
        {
            _roll = roll;
            _extinctionDepletion = extinctionDepletion;
        }
    }
}