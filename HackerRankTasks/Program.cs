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
            // All using of all tasks

            /*
            List<long> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();
            (long min, long max) = MinMaxSum.SolveProblem(arr);
            Console.WriteLine($"{min} {max}");
            
            // --- ---

            int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();
            int result = BirthdayCakeCandles.SolveProblem(candles);
            Console.WriteLine(result);

            // --- ---            

            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> grades = new List<int>();
            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }
            List<int> result =  GradingStudents.SolveProblem(grades);
            for (int i = 0;i < result.Count;i++)
            {
                Console.WriteLine(result[i]);
            }

            // --- ---            

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
            (int applesCount, int orangesCount) = AppleAndOrange.SolveProblem(s, t, a, b, apples, oranges);
            Console.Write($"{applesCount} {orangesCount}");
            
            // --- ---

            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            int result = MigratoryBirds.SolveProblem(arr);
            Console.WriteLine(result);
            
            // --- ---

            int n = Convert.ToInt32(Console.ReadLine().Trim());
            int p = Convert.ToInt32(Console.ReadLine().Trim());
            int result = DrawingBook.SolveProblem(n, p);
            Console.WriteLine(result);
            
            // --- ---

            string[] bnm = Console.ReadLine().Split(' ');
            int b = Convert.ToInt32(bnm[0]);
            int n = Convert.ToInt32(bnm[1]);
            int m = Convert.ToInt32(bnm[2]);
            int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp));
            int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp));
            int moneySpent = ElectronicShop.SolveProblem(keyboards, drives, b);
            Console.WriteLine(moneySpent.ToString());
            
            // --- ---

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int n = Convert.ToInt32(firstMultipleInput[0]);
            int k = Convert.ToInt32(firstMultipleInput[1]);
            List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();
            int b = Convert.ToInt32(Console.ReadLine().Trim());
            int moneySpent = BillDivision.SolveProblem(bill, k, b);
            
            // --- ---

            int n = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
            int result = PickingNumbers.SolveProblem(a);
            Console.WriteLine(result);
            
            // --- ---

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int n = Convert.ToInt32(firstMultipleInput[0]);
            int k = Convert.ToInt32(firstMultipleInput[1]);
            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();
            int result = DivisibleSumPairs.SolveProblem(n, k, ar);
            Console.WriteLine(result);
            
            // --- ---

            int q = Convert.ToInt32(Console.ReadLine());
            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] xyz = Console.ReadLine().Split(' ');
                int x = Convert.ToInt32(xyz[0]);
                int y = Convert.ToInt32(xyz[1]);
                int z = Convert.ToInt32(xyz[2]);
                string result = CatsAndAMouse.SolveProblem(x, y, z);
                Console.WriteLine(result);
            }
            
            // --- ---

            int rankedCount = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> ranked = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(rankedTemp => Convert.ToInt32(rankedTemp)).ToList();
            int playerCount = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> player = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(playerTemp => Convert.ToInt32(playerTemp)).ToList();
            List<int> result = ClimbingTheLeadboard.SolveProblem(ranked, player);
            Console.WriteLine(String.Join("\n", result));
            
            // --- ---

            int t = Convert.ToInt32(Console.ReadLine().Trim());
            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
                int n = Convert.ToInt32(firstMultipleInput[0]);
                int k = Convert.ToInt32(firstMultipleInput[1]);
                List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
                string result = AngryProfessor.SolveProblem(k, a);
                Console.WriteLine(result);
            }
            
            // --- ---

            int n = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            List<int> result = CutTheSticks.SolveProblem(arr);
            Console.WriteLine(String.Join("\n", result));
            
            // --- ---

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int i = Convert.ToInt32(firstMultipleInput[0]);
            int j = Convert.ToInt32(firstMultipleInput[1]);
            int k = Convert.ToInt32(firstMultipleInput[2]);
            int result = BeautifulDaysAtTheMovies.SolveProblem(i, j, k);
            Console.WriteLine(result);
            
            // --- ---

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int n = Convert.ToInt32(firstMultipleInput[0]);
            int k = Convert.ToInt32(firstMultipleInput[1]);
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            int result = LisasWorkbook.SolveProblem(n, k, arr);
            Console.WriteLine(result);
            
            // --- ---

            int n = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> p = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(pTemp => Convert.ToInt32(pTemp)).ToList();
            List<int> result = SequenceEquasion.SolveProblem(p);
            Console.WriteLine(String.Join("\n", result));
            
            // --- ---

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int n = Convert.ToInt32(firstMultipleInput[0]);
            int k = Convert.ToInt32(firstMultipleInput[1]);
            int q = Convert.ToInt32(firstMultipleInput[2]);
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
            List<int> queries = new List<int>();
            for (int i = 0; i < q; i++)
            {
                int queriesItem = Convert.ToInt32(Console.ReadLine().Trim());
                queries.Add(queriesItem);
            }
            List<int> result = CircularArrayRotation.SolveProblem(a, k, queries);
            Console.WriteLine(String.Join("\n", result));
            
            // --- ---

            int t = Convert.ToInt32(Console.ReadLine().Trim());
            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
                int n = Convert.ToInt32(firstMultipleInput[0]);
                int m = Convert.ToInt32(firstMultipleInput[1]);
                int s = Convert.ToInt32(firstMultipleInput[2]);
                int result = SaveThePrisoner.SolveProblem(n, m, s);
                Console.WriteLine(result);
            }
            
            // --- ---

            int q = Convert.ToInt32(Console.ReadLine().Trim());
            for (int qItr = 0; qItr < q; qItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());
                List<List<int>> container = new List<List<int>>();
                for (int i = 0; i < n; i++)
                {
                    container.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(containerTemp => Convert.ToInt32(containerTemp)).ToList());
                }
                string result = OrganizingContainersOfBalls.SolveProblem(container);
                Console.WriteLine(result);
            }
            
            // --- ---

            string s = Console.ReadLine();
            string result = Encryption.SolveProblem(s);
            Console.WriteLine(result);
            
            // --- ---

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int n = Convert.ToInt32(firstMultipleInput[0]);
            int k = Convert.ToInt32(firstMultipleInput[1]);
            string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int r_q = Convert.ToInt32(secondMultipleInput[0]);
            int c_q = Convert.ToInt32(secondMultipleInput[1]);
            List<List<int>> obstacles = new List<List<int>>();
            for (int i = 0; i < k; i++)
            {
                obstacles.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(obstaclesTemp => Convert.ToInt32(obstaclesTemp)).ToList());
            }
            int result = QueensAttackII.SolveProblem(n, k, r_q, c_q, obstacles);
            Console.WriteLine(result);
            */
            // --- ---

            int q = Convert.ToInt32(Console.ReadLine().Trim());
            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
                int a = Convert.ToInt32(firstMultipleInput[0]);
                int b = Convert.ToInt32(firstMultipleInput[1]);
                int result = SherlockAndSquares.SolveProblem(a, b);
                Console.WriteLine(result);
            }
        }
    }
}