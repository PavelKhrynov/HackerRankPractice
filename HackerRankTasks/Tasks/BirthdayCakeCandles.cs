using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks.Tasks
{
    /*
        You are in charge of the cake for a child's birthday.
        You have decided the cake will have one candle for each year of their total age.
        They will only be able to blow out the tallest of the candles.
        Count how many candles are tallest.
    */
    internal class BirthdayCakeCandles
    {
        /// <summary>
        /// Count how many candles are tallest 
        /// </summary>
        /// <param name="candles">List of candle's height</param>
        /// <returns>Number of tallest candles</returns>
        public static int StartTask(List<int> candles)
        {
            int max = candles.Max();
            return candles.Count(x => x == max);
        }
    }
}
