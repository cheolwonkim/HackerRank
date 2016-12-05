using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        string[] arr_temp2 = Console.ReadLine().Split(' ');
        int[] arr_temp3 = Array.ConvertAll(arr_temp2, Int32.Parse);
        int N = arr_temp3[0];
        int k = arr_temp3[1];

        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] problems = Array.ConvertAll(arr_temp, Int32.Parse);

        int result = 0;
        int pageCount = 0;

        for (int i = 0; i < N; i++)
        {
            pageCount++;
            for (int j = 1; j <= problems[i]; j++)
            {
                if (pageCount == j)
                {
                    result++;
                }
                if ((j % k == 0) && (j != problems[i]))
                {
                    pageCount++;
                }
            }

        }
        Console.WriteLine(result);

    }
}