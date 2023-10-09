using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks.Tasks
{
    internal class BillDivision
    {
        public static int StartTask(List<int> bill, int k, int b)
        {
            int totalSum = (bill.Sum() - bill[k]) / 2;
            return totalSum == b ? -1 : b - totalSum;
        }
    }
}
