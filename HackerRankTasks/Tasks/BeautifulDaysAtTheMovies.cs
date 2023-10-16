using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks.Tasks
{
    /*
        Lily likes to play games with integers.
        She has created a new game where she determines the difference between a number and its reverse.
        For instance, given the number 12, its reverse is 21. Their difference is 9.
        The number 120 reversed is 21, and their difference is 99.
        She decides to apply her game to decision making.
        She will look at a numbered range of days and will only go to a movie on a beautiful day.
        Given a range of numbered days, [i...j] and a number k, determine the number of days in the range that are beautiful.
        Beautiful numbers are defined as numbers where |i -reverse(i)| is evenly divisible by k.
        If a day's value is a beautiful number, it is a beautiful day.
        Return the number of beautiful days in the range.
    */
    internal class BeautifulDaysAtTheMovies
    {
        /// <summary>
        /// Count number of butiful days
        /// </summary>
        /// <param name="i">Starting day number</param>
        /// <param name="j">Ending day number</param>
        /// <param name="k">Divisor</param>
        /// <returns>Number of buteful days</returns>
        public static int SolveProblem(int i, int j, int k)
        {
            int result = 0;

            for (int dayNumber = i; dayNumber <= j; dayNumber++) 
            {
                // получение обратного числа
                int reversedNumber = 0;
                int numberToProcess = dayNumber;
                while (numberToProcess > 0)
                {
                    int remainder = numberToProcess % 10;
                    reversedNumber = reversedNumber *10 + remainder;
                    numberToProcess /= 10;
                }
                // проверка условия
                if (Math.Abs(dayNumber - reversedNumber) % k == 0)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
