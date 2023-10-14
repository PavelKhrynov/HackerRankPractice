using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks.Tasks
{
    /*
        Two friends Anna and Brian, are deciding how to split the bill at a dinner.
        Each will only pay for the items they consume.
        Brian gets the check and calculates Anna's portion.
        You must determine if his calculation is correct.
    */
    internal class BillDivision
    {
        /// <summary>
        /// Determine if bill division was right
        /// </summary>
        /// <param name="bill">List of bills</param>
        /// <param name="k">Index of bill that will be exkluded</param>
        /// <param name="b">Amount of money from Anna for bills</param>
        /// <returns>'Bon Appetit' if evefithing right or how much Brian must refund to Anna</returns>
        public static int SolveProblem(List<int> bill, int k, int b)
        {
            int totalSum = (bill.Sum() - bill[k]) / 2;
            return totalSum == b ? -1 : b - totalSum;
        }
    }
}
