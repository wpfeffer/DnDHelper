using System.Security.Cryptography;

namespace DMG.win
{
    public static class DieRoll
    {
        public static int GetRandom()
        {
            return RandomNumberGenerator.GetInt32(6) + 1;
        }

        public static int GetRandom(int maxValue)
        {
            return RandomNumberGenerator.GetInt32(1, maxValue + 1);
        }

        public static int GetRandom(int minValue, int maxValue)
        {
            return RandomNumberGenerator.GetInt32(minValue, maxValue + 1);
        }
    }
}
