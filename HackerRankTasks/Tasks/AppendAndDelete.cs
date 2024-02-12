using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks.Tasks
{
    /*
        You have two strings of lowercase English letters.
        You can perform two types of operations on the first string:
        - Append a lowercase English letter to the end of the string.
        - Delete the last character of the string.
          Performing this operation on an empty string results in an empty string.
        Given an integer, k, and two strings, s and t, determine whether or not you can convert s to t by performing exactly k of the above operations on s.
        If it's possible, print Yes. Otherwise, print No.
    */
    internal class AppendAndDelete
    {
        public static string SolveProblem(string s, string t, int k)
        {
            int sLength = s.Length;
            int tLength = t.Length;
            int commonLetterNumber = 0;
            for (int i = 0; i < Math.Min(sLength, tLength); i++)
            {
                if (s[i] == t[i])
                {
                    commonLetterNumber++;
                }
                else
                {
                    break;
                }
            }

            if ((sLength - commonLetterNumber) + (tLength - commonLetterNumber) > k)
            {
                return "No";
            }
            if (((sLength - commonLetterNumber) + (tLength - commonLetterNumber))%2 == k%2)
            {
                return "Yes";
            }
            if (sLength + tLength < k)
            {
                return "Yes";
            }

            return "No";
        }
    }
}
