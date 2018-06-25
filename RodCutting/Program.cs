using System;

namespace RodCutting
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Dynamic Programming 
               Given a rod of length n inches and an array of prices that contains prices of all 
               pieces of size smaller or equal to n. Determine the maximum value obtainable by cutting 
               up the rod and selling the pieces. For example, if length of the rod is 8 and the 
               values of different pieces are given as following, then the maximum obtainable 
               value is 22(by cutting in two pieces of lengths 2 and 6)


               length | 1   2   3   4   5   6   7   8
               --------------------------------------------
                price | 1   5   8   9  10  17  17  20

               And if the prices are as following, then the maximum obtainable value is 24(by cutting in eight pieces of length 1)

               length | 1   2   3   4   5   6   7   8
               --------------------------------------------
                price | 3   5   8   9  10  17  17  20

           */

            int[] prices = { 0, 1, 5, 8, 9, 10, 17, 17, 20 };
            int length = 0;

            length = 1;
            Console.WriteLine("Maximum Revenue for {0} inch rod is {1}", length, MaxRevenue(length, prices));

            length = 2;
            Console.WriteLine("Maximum Revenue for {0} inch rod is {1}", length, MaxRevenue(length, prices));

            length = 4;
            Console.WriteLine("Maximum Revenue for {0} inch rod is {1}", length, MaxRevenue(length, prices));

            length = 8;
            Console.WriteLine("Maximum Revenue for {0} inch rod is {1}", length, MaxRevenue(length, prices));
        }

        static int MaxRevenue(int len, int[] p)
        {
            int revenue = 0;
            if (len == 0)
                return 0;

            // for each size piece
            for (int i=1; i <= len; i++ )
            {
                revenue = Math.Max(revenue, p[i] + MaxRevenue(len - i, p));
            }
            return revenue;
        }
        
    }
}
