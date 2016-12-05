using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cut_the_Sticks
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] sticks = Array.ConvertAll(arr_temp, Int32.Parse);

            int count = 0;
            int min;

            while (true)
            {
                min = int.MaxValue;
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if (sticks[j] != 0)
                        {
                            min = sticks[j];
                            break;
                        }
                    }
                }
                for (int i = 0; i < N; i++)
                {
                    if (min > sticks[i] && sticks[i] != 0)
                    {
                        min = sticks[i];
                    }
                }

                for (int i = 0; i < N; i++)
                {
                    if (sticks[i] > 0)
                    {
                        sticks[i] -= min;
                        count++;
                    }
                }
                if (count == 0)
                {
                    break;
                }
                Console.WriteLine(count);

                count = 0;
            }

        }
    }
}
