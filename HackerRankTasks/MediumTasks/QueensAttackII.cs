using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks.MediumTasks
{
    /*
         It's about chess and here is full explanation: https://www.hackerrank.com/challenges/queens-attack-2/problem
    */
    internal class QueensAttackII
    {
        public static int SolveProblem(int n, int k, int r_q, int c_q, List<List<int>> obstacles)
        {
            // устанавливаем начальное число позиций для атаки в каждую сторону
            // вертикаль и горизонталь
            int rowTopLimit = n - r_q;
            int rowBottomLimit = r_q - 1;
            int columnLeftLimit = c_q - 1;
            int columnRightLimit = n - c_q;

            // диагонали
            int diagonalTopLeftLimit = Math.Min(rowTopLimit, columnLeftLimit);
            int diagonalTopRightLimit = Math.Min(rowTopLimit, columnRightLimit);
            int diagonalBottomLeftLimit = Math.Min(rowBottomLimit, columnLeftLimit);
            int diagonalBottomRightLimit = Math.Min(rowBottomLimit, columnRightLimit);

            // один проход по препятствиям
            foreach (var obstacle in obstacles)
            {
                int posR = obstacle[0];
                int posC = obstacle[1];

                // если препятствие не стоит на линии атаки, то его не надо обрабатывать
                if (posR != r_q && posC != c_q && Math.Abs(posR - r_q) != Math.Abs(posC - c_q))
                {
                    continue;
                }
                // для каждого направления надо высчитать сколько будет позиций для атаки от королевы до препятствия и взять минимум из этого и прошлого найденного
                // -1 везде потому что надо исключить саму клетку препятствия из формулы

                // если препятствие на вертикали сверху от королевы
                if (posC == c_q && posR > r_q)
                {
                    int limit = posR - r_q - 1;
                    rowTopLimit = Math.Min(limit, rowTopLimit);
                    continue;
                }
                // если препятсивие на вертикали снизу от королевы
                if (posC == c_q && posR < r_q)
                {
                    int limit = r_q - posR - 1;
                    rowBottomLimit = Math.Min(limit, rowBottomLimit);
                    continue;
                }
                // горизонталь, справа
                if (posR == r_q && posC > c_q)
                {
                    int limit = posC - c_q - 1;
                    columnRightLimit = Math.Min(limit, columnRightLimit);
                    continue;
                }
                // коризонталь, слева
                if (posR == r_q && posC < c_q)
                {
                    int limit = c_q - posC - 1;
                    columnLeftLimit = Math.Min(limit, columnLeftLimit);
                    continue;
                }

                // диагонали
                // сверху справа =
                if (posR > r_q && posC > c_q)
                {
                    int limit = Math.Min(posR - r_q, posC - c_q) - 1;
                    diagonalTopRightLimit = Math.Min(diagonalTopRightLimit, limit);
                    continue;
                }
                // снизу справа
                if (posR < r_q && posC > c_q)
                {
                    int limit = Math.Min(r_q - posR, posC - c_q) - 1;
                    diagonalBottomRightLimit = Math.Min(diagonalBottomRightLimit, limit) - 1;
                    continue;
                }
                // сверзу слева
                if (posR > r_q && posC < c_q)
                {
                    int limit = Math.Min(posR - r_q, c_q - posC) - 1;
                    diagonalTopLeftLimit = Math.Min(diagonalTopLeftLimit, limit);
                    continue;
                }
                // снизу слева
                if (posR < r_q && posC < c_q)
                {
                    int limit = Math.Min(r_q - posR, c_q - posC) - 1;
                    diagonalBottomLeftLimit = Math.Min(diagonalBottomLeftLimit, limit);
                    continue;
                }
            }

            // сумма атак в каждом направлении
            return rowTopLimit + rowBottomLimit + columnLeftLimit + columnRightLimit +
                diagonalTopRightLimit + diagonalTopLeftLimit + diagonalBottomLeftLimit + diagonalBottomRightLimit; ;
        }
    }
}
