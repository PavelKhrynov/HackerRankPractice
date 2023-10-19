using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks.Tasks
{
    /*
        Given a sequence of n integers, p(1), p(2), ..., p(n) where each element is distinct and satisfies 1 <= p(x) <= n.
        For each x where 1 <= x <= n, that is x increments from 1 to n, find any integer y such that p(p(y)) == x and keep a history of the values of y in a return array.
    */
    internal class SequenceEquasion
    {
        public static List<int> SolveProblem(List<int> p)
        {
            var result = new List<int>();

            for (int i = 0; i < p.Count; i++)
            {
                int x = i + 1;
                int x1 = p.IndexOf(x) + 1;
                int y = p.IndexOf(x1) + 1;
                result.Add(y);
            }

            return result;
        }
    }
}
