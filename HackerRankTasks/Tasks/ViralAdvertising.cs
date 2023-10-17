using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks.Tasks
{
    /*
        HackerLand Enterprise is adopting a new viral advertising strategy.
        When they launch a new product, they advertise it to exactly 5 people on social media.
        On the first day, half of those 5 people (i.e., floor(5/2) = 2) like the advertisement and each shares it with 3 of their friends.
        At the beginning of the second day, floor(5/2)*3 = 2*3 = 6 people receive the advertisement.
        Each day, floor(recipient/2) of the recipients like the advertisement and will share it with 3 friends on the following day.
        Assuming nobody receives the advertisement twice, determine how many people have liked the ad by the end of a given day, beginning with launch day as day 1.
    */
    internal class ViralAdvertising
    {
        /// <summary>
        /// Count involved people on specific day
        /// </summary>
        /// <param name="n">Final day</param>
        /// <returns>Number of people</returns>
        public static int SolveProblem(int n)
        {
            int totalPeople = 5;
            int totalLikes = 0;
            for (int i = 0; i < n; i++)
            {
                totalPeople /= 2;
                totalLikes += totalPeople;
                totalPeople *= 3;
            }

            return totalLikes;
        }
    }
}
