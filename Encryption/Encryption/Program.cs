using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            string readString = Console.ReadLine();
            string removeSpaceString = readString.Replace(" ", "");

            int temp = (int)Math.Sqrt(removeSpaceString.Length);
            int floor, ceil;

            if ((temp * (temp + 1)) < removeSpaceString.Length)
                floor = temp + 1;
            else
                floor = temp;

            temp = floor;
            if ((temp * temp) >= removeSpaceString.Length)
                ceil = temp;
            else
                ceil = temp + 1;


            int i, j;
            for (j = 0; j < ceil; j++)
            {
                for (i = 0; i < floor; i++)
                {
                    if ((ceil * i + j) >= (removeSpaceString.Length))
                        break;

                    Console.Write(removeSpaceString[ceil * i + j]);
                }
                Console.Write(" ");
            }
        }
    }
}
