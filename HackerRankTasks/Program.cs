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
            int T = Convert.ToInt32(Console.ReadLine().Trim());
            for (int TItr = 0; TItr < T; TItr++)
            {
                string w = Console.ReadLine();
                string result = BiggerIsGreater.SolveProblim(w);
                Console.WriteLine(result);
            }
        }
    }
}