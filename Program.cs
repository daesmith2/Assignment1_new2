using System;
using System.Globalization;
using System.Linq;

using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Assignment1_new
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            PrintTriangle(n);

            int n2 = 5;
            PrintSeriesSum(n2);

            int[] A = new int[] { 1, 2, 2, 6 }; ;
            bool check = MonotonicCheck(A);
            Console.WriteLine(check);

            int[] nums = new int[] { 3, 1, 4, 1, 5 };
            int k = 2;
            int pairs = DiffPairs(nums, k);
            Console.WriteLine(pairs);

            string keyboard = "abcdefghijklmnopqrstuvwxyz";
            string word = "dis";
            int time = BullsKeyboard(keyboard, word);
            Console.WriteLine(time);

            string str1 = "goulls";
            string str2 = "gobulls";
            int minEdits = StringEdit(str1, str2);
            Console.WriteLine(minEdits);

        }

        // *** #1. For the triangle I created a for loop that had five possible layers. 
        //         Input allows you to select how many times the console will write the
        //         next item in the array.In order to keep the * centered I just added the proportionate 
        //         amount of spaces preceding each item.
        // *** 

        public static void PrintTriangle(int x)
        {
            Console.Write("Please enter a number between 1 and 5: ");

            try
            {
                string input = Console.ReadLine();

                int value_of_input = int.Parse(input);

                string[] layers = { "    *", "   ***", "  *****", " *******", "*********" };


                // Iterate through the array using a For Loop
                for (int i = 0; i < value_of_input; i++)
                {
                    // layers[i] = layers;
                    Console.WriteLine(layers[i]);
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing PrintTriangle()");
            }
        }


        // *** #2. A predefined array of odd numbers is created. 15 items are in the array.
        //     The value that is input is iterated through the array that many times, and for each    
        //     odd number iterated through, is summed together and then printed. The summing and printing takes place after listing 
        //     selected odds in the array.
        // *** 
        public static void PrintSeriesSum(int n)
        {
            Console.Write("Please enter a number between 1 and 15: ");


            try
            {
                string input = Console.ReadLine();

                int value_of_input = int.Parse(input);

                int[] odds = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29 };

                var newArray = odds.Take(odds.Length - 15 + value_of_input).ToArray();

                int sum = 0;
                for (int i = 0; i < value_of_input; i++)
                {
                    Console.WriteLine(odds[i]);

                }
                Array.ForEach(newArray, i => sum += i);
                Console.WriteLine(sum);

            }
            catch
            {
                Console.WriteLine("You did not select a number between 1 and 15");
            }
        }

        // #3 This was the most confusing to me originally conceptually. After seeing calculus graphs (Economics being one of my undergrad degrees), I understood the goal
        //    of this program. Being comfortable with integers I simply created an inequality where if all 4 steps of the array were only going up and neutral, or down and neutral
        //    then the respective printout of decreasing or increasing would occur. Else it would print as Not monotonic. 

        public static bool MonotonicCheck(int[] n)
        {
            try
            {
             
                int[] A2 = { 1, 2, 2, 6 };
                //   for (int i = 0; i < 4; i++)

                 if (A2[0] <= A2[1] & A2[1] <= A2[2] & A2[2] <= A2[3])

                    { Console.WriteLine("Increasing");}
                 else if (A2[0] >= A2[1] & A2[1] >= A2[2] & A2[2] >= A2[3]) 
                  { Console.WriteLine("Decreasing"); }
                    else
                    { Console.WriteLine("Not Monotonic"); }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing MonotonicCheck()");
            }

            return false;
        }
        // *** #4. In this case I manually coded the absolute value of each possible difference between members of the array.
        //     Ie once knowing |H[0] - H[1]|, I know longer need to subtract and list |H[1] - H[0]|, as that pair is already printed if =2. 
        //     This method obviously could be done with some sort of loop, but I had difficulty with the syntax of using diff[i], when I tried to make 
        //     diff[i] = H[0], I got an message that it was string to boolean etc. However any edit of the H array should print the pairs if the difference between them is two.
        // *** 

        public static int DiffPairs(int[] J, int k)
        {
            try
            {
                int[] H = { 3, 1, 4, 1, 5 };

                int diff0 = Math.Abs(H[0] - H[1]);
                int diff1 = Math.Abs(H[0] - H[2]);
                int diff2 = Math.Abs(H[0] - H[3]);
                int diff3 = Math.Abs(H[0] - H[4]);

                if (diff0 == 2)

                {
                    Console.WriteLine("Pair");
                    Console.WriteLine(H[0]);
                    Console.WriteLine(H[1]);

                }

                if (diff1 == 2)

                {
                    Console.WriteLine("Pair");
                    Console.WriteLine(H[0]);
                    Console.WriteLine(H[2]);

                }

                if (diff2 == 2)

                {
                    Console.WriteLine("Pair");
                    Console.WriteLine(H[0]);
                    Console.WriteLine(H[3]);

                }

                if (diff2 == 2)

                {
                    Console.WriteLine("Pair");
                    Console.WriteLine(H[0]);
                    Console.WriteLine(H[4]);

                }

                int diff0b = Math.Abs(H[1] - H[2]);
                int diff1b = Math.Abs(H[1] - H[3]);
                int diff2b = Math.Abs(H[1] - H[4]);

                if (diff0b == 2)

                {
                    Console.WriteLine("Pair");
                    Console.WriteLine(H[1]);
                    Console.WriteLine(H[2]);

                }

                if (diff1b == 2)

                {
                    Console.WriteLine("Pair");
                    Console.WriteLine(H[1]);
                    Console.WriteLine(H[2]);

                }

                if (diff2b == 2)

                {
                    Console.WriteLine("Pair");
                    Console.WriteLine(H[1]);
                    Console.WriteLine(H[4]);

                }

                int diff1c = Math.Abs(H[2] - H[3]);
                int diff2c = Math.Abs(H[2] - H[4]);

                if (diff1c == 2)

                {
                    Console.WriteLine("Pair");
                    Console.WriteLine(H[2]);
                    Console.WriteLine(H[3]);

                }

                if (diff2c == 2)

                {
                    Console.WriteLine("Pair");
                    Console.WriteLine(H[2]);
                    Console.WriteLine(H[4]);
                }
                int diff3d = Math.Abs(H[3] - H[4]);

                if (diff3d == 2)

                {
                    Console.WriteLine("Pair");
                    Console.WriteLine(H[3]);
                    Console.WriteLine(H[4]);
                }
   
            }
            catch
            {
                Console.WriteLine("Exception occured while computing DiffPairs()");
            }

          return 0;
        }

        // #5 I tried many ways of using an array to index each letter, and subsequently compute the difference of the index values. 
        //    syntactically this became another challenge with data types and I had to do more research using idx and charAt in Java from leetcode/stackoverflow. 
        //    I don't entirely understand why this works. It minuses 'a' to sum the differences between letters, I'm assuming 'a' is a symbol somehow.
        //    However it does work correctly.

 
           public static int BullsKeyboard(String keyboard, String word)
        {
            if (word == null || word.Length == 0)
            {
                return 0;
            }
            int[] idx = new int[26];
            for (int i = 0; i < keyboard.Length; i++)
            {
                idx[keyboard.ElementAt(i) - 'a'] = i;
            }
            int res = 0;
            for (int i = -1, j = 0; j < word.Length; i++, j++)
            {
                if (i == -1)
                {
                    res += Math.Abs(idx[word.ElementAt(0) - 'a'] - 0);
                }
                else
                {
                    res += Math.Abs(idx[word.ElementAt(j) - 'a'] - idx[word.ElementAt(i) - 'a']);
                }
            }
            return res;
        }
        public static int StringEdit(string str1, string str2)
        {
            try
            {
                // #6 Please refer to second routine ***
            }
            catch
            {
                Console.WriteLine("Exception occured while computing StringEdit()");
            }

            return 0;
        }
    }

   
}
