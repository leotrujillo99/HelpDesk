using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angel_Code.Angel.SCRAP
{
    public class Part_B
    {
        public static void BubbleSort(int[] arr, string type)
        {
            if (type == "asc")
            {
                Part_B_Methods.sortArrayAscBS(arr);
            }
            else if (type == "dec")
            {
                Part_B_Methods.sortArrayDescBS(arr);
            }
            Console.WriteLine("**********Section 1 - Bubble Sort Ascending **********");
            Console.WriteLine();

        }
    }
}
