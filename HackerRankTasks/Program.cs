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
            string s = Console.ReadLine();

            string t = Console.ReadLine();

            int k = Convert.ToInt32(Console.ReadLine().Trim());

            string result = AppendAndDelete.SolveProblem(s, t, k);

            Console.WriteLine(result);
        }
    }
}