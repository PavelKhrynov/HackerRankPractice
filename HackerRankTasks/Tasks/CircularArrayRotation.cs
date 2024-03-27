using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks.Tasks
{
    /*
        John Watson knows of an operation called a right circular rotation on an array of integers.
        One rotation operation moves the last array element to the first position and shifts all remaining elements right one.
        To test Sherlock's abilities, Watson provides Sherlock with an array of integers.
        Sherlock is to perform the rotation operation a number of times then determine the value of the element at a given position.
        For each array, perform a number of right circular rotations and return the values of the elements at the given indices. 
    */
    internal class CircularArrayRotation
    {
        public static List<int> SolveProblem(List<int> a, int k, List<int> queries)
        {
            var result = new List<int>();

            int arrayLenght = a.Count;
            // посчитаем сколько смещений вправо будет, без учета полного цикла массива
            int moveWithoutCicles = k - (k / arrayLenght) * arrayLenght;

            for (int i = 0; i < queries.Count; i++)
            {
                int indexToFound = queries[i];
                int indexAfterShift = indexToFound - moveWithoutCicles;
                if (indexAfterShift < 0)
                {
                    indexAfterShift = indexAfterShift + a.Count;
                }
                result.Add(a[indexAfterShift]);
            }

            return result;
        }
    }
}
