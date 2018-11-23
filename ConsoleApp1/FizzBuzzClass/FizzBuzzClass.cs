using System;

namespace FizzBuzzNamespace
{
    /// <summary>
    /// class to hold methodes for FizzBuzz, a simple programming challange that prints out a number of items with all dividable by 3 beeing
    /// replaced by Fizz, dividable by 5 Buzz and dividable by both FizzBuzz
    /// </summary>
    public static class FizzBuzzClass
    {
        //variabbles to hold the start and end point of the fizzbuzz sequence, defaulting to 0 to 100
        static int g_start = 1;
        static int g_end = 100;

        //variables holding the divders to replace by a word( for easy modification)
        static int g_fizz = 3;
        static int g_buzz = 5;
        static int g_fizzbuzz = 3 * 5;



        /// <summary>
        /// metode to return a fizzbuzz sequence with given start and end
        /// </summary>
        /// <param name="start">the start of the sequence</param>
        /// <param name="end">the end of the sequence</param>
        /// <returns>array of strings containing the fizzbuzz sequence</returns>
        public static string[] Calculate(int start, int end)
        {
            string[] sequence = new string[end + 1];

            //using a for loop to check each number for fizzbuzz
            for (int i = start; i < end + 1; i++)
            {
                //checking for fizz/buzz/fizzbuzz by using modulo
                if (i % g_fizzbuzz == 0)
                {
                    sequence[i] = "FizzBuzz";
                }
                else if (i % g_fizz == 0)
                {
                    sequence[i] = "Fizz";

                }
                else if (i % g_buzz == 0)
                {
                    sequence[i] = "Buzz";
                }
                else
                {
                    sequence[i] = i.ToString();
                }
                
            }

            return sequence;
        }


        /// <summary>
        /// metode to return a fizzbuzz sequence with given end starting from 0
        /// </summary>
        /// <param name="end">the end of the sequence</param>
        /// <returns>array of strings containing the fizzbuzz sequence</returns>
        public static string[] Calculate(int end)
        {
            return Calculate(g_start, end);

        }

        /// <summary>
        /// methode to retun a fizzbuzz sequence with the classic start/end of 1 and 100
        /// </summary>
        /// <returns></returns>
        public static string[] Calculate()
        {
            return Calculate(g_start, g_end);
        }


    }
}
