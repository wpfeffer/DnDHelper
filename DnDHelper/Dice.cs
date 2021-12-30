using System.Security.Cryptography;

namespace DnDHelper
{
    /// <summary>
    /// This is a utility class used to generate a random number from the roll of a die.
    /// </summary>
    public class Dice
    {
        private static RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();

        /// <summary>
        /// This method takes as input the number of sides on a die and returns a random number between 1 and the number of sides.
        /// </summary>
        /// <param name="numberSides">The number of sides on the die.</param>
        /// <returns>Returns a random number between 1 and numberSides.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Throws this exception if the numberSides passed in is less than or equal to 0.</exception>
        public static byte Roll(byte numberSides)
        {
            if (numberSides <= 0)
                throw new ArgumentOutOfRangeException("numberSides");

            byte[] randomNumber = new byte[1];
            do
            { 
                rngCsp.GetBytes(randomNumber);
            }
            while (!IsFairRoll(randomNumber[0], numberSides));
            return (byte)((randomNumber[0] % numberSides) + 1);
        }

        private static bool IsFairRoll(byte roll, byte numSides)
        {
            int fullSetsOfValues = Byte.MaxValue / numSides;
            return roll < numSides * fullSetsOfValues;
        }
    }
}