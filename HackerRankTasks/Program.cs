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
            int p = Convert.ToInt32(Console.ReadLine().Trim());

            int q = Convert.ToInt32(Console.ReadLine().Trim());

            var result = ModifiedKaprekarNumbers.SolveProblem(p, q);

            if (result.Count == 0)
            {
                Console.WriteLine("INVALID RANGE");
            }
            else
            {
                for (int i = 0; i < result.Count; i++)
                {
                    Console.Write(result[i] + " ");
                }
            }
        }
    }
}