using System;
using HackerRankTasks.Tasks;

namespace HackerRankTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            List<long> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();
            (long min, long max) = MinMaxSum.StartTask(arr);
            Console.WriteLine($"{min} {max}");
            

            int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();
            int result = BirthdayCakeCandles.StartTask(candles);
            Console.WriteLine(result);
            

            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> grades = new List<int>();
            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }
            List<int> result =  GradingStudents.StartTask(grades);
            for (int i = 0;i < result.Count;i++)
            {
                Console.WriteLine(result[i]);
            }
            

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int s = Convert.ToInt32(firstMultipleInput[0]);
            int t = Convert.ToInt32(firstMultipleInput[1]);
            string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int a = Convert.ToInt32(secondMultipleInput[0]);
            int b = Convert.ToInt32(secondMultipleInput[1]);
            string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int m = Convert.ToInt32(thirdMultipleInput[0]);
            int n = Convert.ToInt32(thirdMultipleInput[1]);
            List<int> apples = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();
            List<int> oranges = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();
            (int applesCount, int orangesCount) = AppleAndOrange.StartTask(s, t, a, b, apples, oranges);
            Console.Write($"{applesCount} {orangesCount}");
            

            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            int result = MigratoryBirds.StartTask(arr);
            Console.WriteLine(result);
            

            int n = Convert.ToInt32(Console.ReadLine().Trim());
            int p = Convert.ToInt32(Console.ReadLine().Trim());
            int result = DrawingBook.StartTask(n, p);
            Console.WriteLine(result);
            */

            string[] bnm = Console.ReadLine().Split(' ');
            int b = Convert.ToInt32(bnm[0]);
            int n = Convert.ToInt32(bnm[1]);
            int m = Convert.ToInt32(bnm[2]);
            int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp));
            int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp));
            int moneySpent = ElectronicShop.StartTask(keyboards, drives, b);
            Console.WriteLine(moneySpent.ToString());
        }
    }
}