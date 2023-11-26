using System;
using System.IO;
using HackerRankTasks.Tasks;
using HackerRankTasks.MediumTasks;

namespace HackerRankTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int b = Convert.ToInt32(firstMultipleInput[0]);

                int w = Convert.ToInt32(firstMultipleInput[1]);

                string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int bc = Convert.ToInt32(secondMultipleInput[0]);

                int wc = Convert.ToInt32(secondMultipleInput[1]);

                int z = Convert.ToInt32(secondMultipleInput[2]);

                long result = TaumAndBday.SolveProblem(b, w, bc, wc, z);

                Console.WriteLine(result);
            }
        }
    }
}