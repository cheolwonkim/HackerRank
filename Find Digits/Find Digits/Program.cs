using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            int MAX = 1000000000;
            int n = Convert.ToInt32(Console.ReadLine());
            int remainderN = n;
            int digitN = MAX; ;
            int di;
            int count = 0;
            while (digitN > n)
            {
                digitN /= 10;
            }

            while (digitN >= 1)
            {
                di = remainderN / digitN;
                if ((di != 0) && ((n % di) == 0))
                {
                    count++;
                }
                remainderN = remainderN % digitN;
                digitN /= 10;
            }
            Console.WriteLine(count);
        }
    }
}

