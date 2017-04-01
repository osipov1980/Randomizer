using System;

namespace Randomizer
{
    class RandomNum
    {
        // Method
        public int GenerateRandomNumber(int[] numSize)
        {
            int fromNum = numSize[0];
            int toNum = numSize[1];

            Random rnd = new Random();
            int num = rnd.Next(fromNum, toNum);  // creates a number between fromNum and toNum
            return num;
        }
    }
}
