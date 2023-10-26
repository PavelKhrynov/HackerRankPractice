using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks.MediumTasks
{
    /*
        David has several containers, each with a number of balls in it. He has just enough containers to sort each type of ball he has into its own container.
        David wants to sort the balls using his sort method.
        David wants to perform some number of swap operations such that:
        - Each container contains only balls of the same type.
        - No two balls of the same type are located in different containers.
    */
    internal class OrganizingContainersOfBalls
    {
        public static string SolveProblem(List<List<int>> container)
        {
            var totalNumberOfBalls = new int[container.Count]; // List<int>(container.Count);
            var totalSizeOfContainers = new int[container.Count]; //List<int>(container.Count);

            for (int i = 0; i < container.Count; i++)
            {
                for (int j = 0; j < container[i].Count; j++)
                {
                    totalNumberOfBalls[j] += container[i][j];
                    totalSizeOfContainers[i] += container[i][j];
                }
            }

            Array.Sort(totalNumberOfBalls);
            Array.Sort(totalSizeOfContainers);

            for (int i = 0; i < totalNumberOfBalls.Length; i++)
            {
                if (totalNumberOfBalls[i] != totalSizeOfContainers[i])
                    return "Impossible";
            }

            return "Possible";
        }
    }
}
