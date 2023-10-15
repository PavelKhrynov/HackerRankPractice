using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks.Tasks
{
    /*
        You are given a number of sticks of varying lengths.
        You will iteratively cut the sticks into smaller sticks, discarding the shortest pieces until there are none left.
        At each iteration you will determine the length of the shortest stick remaining, cut that length from each of the longer sticks and then discard all the pieces of that shortest length.
        When all the remaining sticks are the same length, they cannot be shortened so discard them.
    */
    internal class CutTheSticks
    {
        /// <summary>
        /// Procedure to cut sticks
        /// </summary>
        /// <param name="arr">List of lenght of sticks</param>
        /// <returns>Numbers of sticks that are left before each iteration until there are none left</returns>
        public static List<int> SolveProblem(List<int> arr)
        {
            int totalCount = arr.Count;
            // Первый элемент будет общее число объектов в массиве, т.к. столько будет после первой итерации
            var result = new List<int> { totalCount };

            // Сортируем массив для простоты дальнейших действий
            arr.Sort();

            // Проходим по отрсортированному массиву
            // Если найдено новое число, значит общее число элементов - текущйи индекс = сколько останется числе после отсечения
            int currentMinStick = arr[0];
            for (int i = 0; i < totalCount; i++)
            {
                if (arr[i] != currentMinStick)
                {
                    result.Add(totalCount - i);
                    currentMinStick = arr[i];
                }
            }

            return result;
        }
    }
}
