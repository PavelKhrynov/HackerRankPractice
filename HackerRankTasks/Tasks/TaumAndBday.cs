using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks.Tasks
{
    /*
        Taum is planning to celebrate the birthday of his friend, Diksha.
        There are two types of gifts that Diksha wants from Taum: one is black and the other is white.
        To make her happy, Taum has to buy b black gifts and w white gifts.
        - The cost of each black gift is bc units.
        - The cost of every white gift is wc units.
        - The cost to convert a black gift into white gift or vice versa is z units.
        Determine the minimum cost of Diksha's gifts.
     */
    internal class TaumAndBday
    {
        public static long SolveProblem(long b, long w, long bc, long wc, long z)
        {
            long firstVariant = b * bc + w * wc;
            long secondVariant = b * (wc + z) + w * wc;
            long thirsVariant = b * bc + w * (bc + z);
            long forthVariant = b * (wc + z) + w * (bc + z);

            return Math.Min(Math.Min(Math.Min(firstVariant, secondVariant), thirsVariant), forthVariant);
        }
    }
}
