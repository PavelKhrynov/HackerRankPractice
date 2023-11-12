using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks.Tasks
{
    /*
        There are a number of people who will be attending ACM-ICPC World Finals (https://en.wikipedia.org/wiki/International_Collegiate_Programming_Contest).
        Each of them may be well versed in a number of topics. Given a list of topics known by each attendee, presented as binary strings, determine the maximum number of topics a 2-person team can know.
        Each subject has a column in the binary string, and a '1' means the subject is known while '0' means it is not.
        Also determine the number of teams that know the maximum number of topics. Return an integer array with two elements.
        The first is the maximum number of topics known, and the second is the number of teams that know that number of topics.
     */
    internal class ACMICPCTeam
    {
        public static List<int> SolveProblem(List<string> topic)
        {
            int teamNumber = 0;
            int maxTopics = 0;

            for (int i = 0; i < topic.Count - 1; i++)
            {
                var firstPerson = topic[i];
                int length = firstPerson.Length;
                for (int j = i + 1; j < topic.Count; j++)
                {
                    var secondPerson = topic[j];
                    int knownTopics = 0;

                    for (int k = 0; k < length; k++)
                    {
                        if (firstPerson[k] == '1' || secondPerson[k] == '1')
                        {
                            knownTopics++;
                        }
                    }

                    if (knownTopics > maxTopics)
                    {
                        maxTopics = knownTopics;
                        teamNumber = 1;
                    }
                    else if (knownTopics == maxTopics)
                    {
                        teamNumber++;
                    }
                }
            }

            return new List<int> { maxTopics , teamNumber };
        }
    }
}
