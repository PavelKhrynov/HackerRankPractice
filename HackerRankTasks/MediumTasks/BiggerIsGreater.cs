using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks.MediumTasks
{
    internal class BiggerIsGreater
    {
        /*
            Lexicographical order is often known as alphabetical order when dealing with strings. 
            A string is greater than another string if it comes later in a lexicographically sorted list.
            Given a word, create a new word by swapping some or all of its characters.
            This new word must meet two criteria:
            - It must be greater than the original word
            - It must be the smallest word that meets the first condition
         */
        public static string SolveProblim(string w)
        {
            var newWord = "no answer";
            int[] charSequence = w.Select(x => Convert.ToInt32(x)).ToArray();

            bool isFound = false;
            int prefixPosition = 0;
            for (int i = charSequence.Length - 1; i > 0; i--)
            {
                if (charSequence[i - 1] < charSequence[i])
                {
                    isFound = true;
                    prefixPosition = i - 1;
                    break;
                }
            }
            if (!isFound)
            {
                return newWord;
            }

            int positionToReplace = prefixPosition + 1;
            for (int i = charSequence.Length - 1; i > prefixPosition; i--)
            {
                if (charSequence[i - 1] >= charSequence[i] && charSequence[i] > charSequence[prefixPosition])
                {
                    positionToReplace = i;
                    break;
                }
            }

            (charSequence[positionToReplace], charSequence[prefixPosition]) = (charSequence[prefixPosition], charSequence[positionToReplace]);
            for (int i = charSequence.Length - 1, j = prefixPosition + 1; i > j; i--, j++)
            {
                (charSequence[i], charSequence[j]) = (charSequence[j], charSequence[i]);
            }

            var stringBuilder = new StringBuilder();

            newWord = new string(charSequence.Select(x => (char)x).ToArray());

            return newWord;
        }  
    }
}
