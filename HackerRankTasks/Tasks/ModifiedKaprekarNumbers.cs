using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks.Tasks
{
    /*
    A modified Kaprekar number is a positive whole number with a special property. 
    If you square it, then split the number into two integers and sum those integers, you have the same value you started with.
    Consider a positive whole number n with d digits.
    We square n to arrive at a number that is either 2*d digits long or (2*d)-1 digits long.
    Split the string representation of the square into two parts, l and r.
    The right hand part, r must be d digits long.
    The left is the remaining substring.
    Convert those two substrings back to integers, add them and see if you get n.
     */
    internal class ModifiedKaprekarNumbers
    {
        public static List<long> SolveProblem(int p, int q)
        {
            var result = new List<long>();

            for (long number = p; number <= q; number++)
            {
                int digitsInNumber = number == 0 ? 1 : (number > 0 ? 1 : 2) + (int)Math.Log10(Math.Abs((double)number));
                long sqareNumber = number * number;

                long firstPartOfNumber = sqareNumber / (long)(Math.Pow(10, digitsInNumber));
                long secondPartOfNumber = sqareNumber % (long)(Math.Pow(10, digitsInNumber));

                //Console.WriteLine($"{firstPartOfNumber}, {secondPartOfNumber}, {number}");
                if (firstPartOfNumber + secondPartOfNumber == number)
                {
                    result.Add(number);
                }
            }

            return result;
        }
    }
}
