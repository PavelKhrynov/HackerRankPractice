using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks.Tasks
{
    internal class MigratoryBirds
    {
        public static int StartTask(List<int> arr)
        {
            var dictionary = new Dictionary<int, int>
            {
                { 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 }
            };

            for (int i = 0; i < arr.Count; i++)
            {
                dictionary[arr[i]]++;
            }

            var maxValue = dictionary.Max(x => x.Value);

            var keyMaxList = dictionary.Where(x => x.Value == maxValue).Select(x => x.Key);

            var result = keyMaxList.Min();

            return result;
        }
    }
}
