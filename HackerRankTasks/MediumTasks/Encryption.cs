using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks.MediumTasks
{
    /*
        An English text needs to be encrypted using the following encryption scheme.
        First, the spaces are removed from the text. Let L be the length of this text.
        Then, characters are written into a grid, whose rows and columns have the following constraints:
        floor(sqrt(L)) <= row <= column <= ceil(sqrt(L))
    */
    internal class Encryption
    {
        public static string SolveProblem(string s)
        {
            int stringLenght = s.Length;
            int rows = (int)Math.Floor(Math.Sqrt(stringLenght)) + 1;
            int columns = (int)Math.Ceiling(Math.Sqrt(stringLenght));

            var result = "";
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    var index = i + j * columns;
                    if (index >= stringLenght)
                        break;

                    result += s[index];
                }
                result += ' ';
            }

            return result;
        }
    }
}
