using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks.Tasks
{
    /*
    Given a sequence of integers a, a triplet (a[i], a[j], a[k]) is beautiful if:
    * i < j < l
    * a[j] - a[i] = a[k] - a[j] = d
    Given an increasing sequenc of integers and the value of d, count the number of beautiful triplets in the sequence.
    */
    internal class BeatifulTriplet
    {
        public static int SolveProblem(int d, List<int> arr)
        {
            int result = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr.Contains(arr[i] + d) && arr.Contains(arr[i] + 2 * d))
                {
                    result++;
                }
            }

            return result;
        }
    }
}
