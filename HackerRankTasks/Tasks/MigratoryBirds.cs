using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks.Tasks
{
    /*
        Given an array of bird sightings where every element represents a bird type id, determine the id of the most frequently sighted type.
        If more than 1 type has been spotted that maximum amount, return the smallest of their ids.
    */
    internal class MigratoryBirds
    {
        /// <summary>
        /// Find the lowest type id of the most frequently sighted birds
        /// </summary>
        /// <param name="arr">List of the types of birds sighted</param>
        /// <returns>The lowest type id of the most frequently sighted birds</returns>
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
