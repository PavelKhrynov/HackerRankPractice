using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks.Tasks
{
    /*
        Watson likes to challenge Sherlock's math ability.
        He will provide a starting and ending value that describe a range of integers, inclusive of the endpoints.
        Sherlock must determine the number of square integers within that range.
    */
    internal class SherlockAndSquares
    {
        public static int SolveProblem(int a, int b)
        {
            int firstNumber = (int)Math.Ceiling(Math.Sqrt(a));
            int lastNumber = (int)Math.Floor(Math.Sqrt(b));
            
            return lastNumber - firstNumber + 1;
        }
    }
}
