using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Testing_for_R_T
{
    public class Part_A
    {
        public static void QuickSort()
        {
            Console.WriteLine();
            Console.WriteLine("**********Section 1 - Quick Sort **********");
            Console.WriteLine();
            int[] myNumbers = { 6501, 9503, 7557, 5535, 5601, 9001, 9888, 8801, 9767, 7815 };
            Console.Write("The array unsorted is: [");
            for (int i = 0; i <= myNumbers.GetUpperBound(0); i++)
            {
                Console.Write(myNumbers[i]);
                if (i != myNumbers.GetUpperBound(0))
                {
                    Console.Write(",");
                }
            }
            Console.Write("]");
            int low = 0;
            int high = myNumbers.Length - 1;
            SortingMethods.quickSort(myNumbers, low, high);
            Console.WriteLine();
            Console.Write("The array sorted is: [");
            for (int i = 0; i <= myNumbers.GetUpperBound(0); i++)
            {
                Console.Write(myNumbers[i]);
                if (i != myNumbers.GetUpperBound(0))
                {
                    Console.Write(",");
                }
            }
            Console.Write("]");
        }

        public static void BubbleSort()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("**********Section 2 - Bubble Sort **********");
            Console.WriteLine();
            int[] myArray = { 5, 90, 35, 45, 150, 3 };
            Console.Write("The array unsorted is : [");
            for (int i = 0; i <= myArray.GetUpperBound(0); i++)
            {
                Console.Write(myArray[i]);
                if (i != myArray.GetUpperBound(0))
                {
                    Console.Write(",");
                }
            }
            Console.Write("]");
            SortingMethods.bubbleSort(myArray);
            Console.WriteLine();
            Console.Write("The array sorted is : [");
            for (int i = 0; i <= myArray.GetUpperBound(0); i++)
            {
                Console.Write(myArray[i]);
                if (i != myArray.GetUpperBound(0))
                {
                    Console.Write(",");
                }
            }
            Console.Write("]");
            Console.WriteLine();
        }

        public static void BinarySearch()
        {
            int[] myNumbers = { 6501, 9503, 7557, 5535, 5601, 9001, 9888, 8801, 9767, 7815 };
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("**********Section 3 - Binary Search**********");
            Console.WriteLine();
            Console.WriteLine(SortingMethods.binarySearch(myNumbers, 8801));
            Console.WriteLine();
            Console.WriteLine(SortingMethods.binarySearch(myNumbers, 7777));
            Console.ReadKey();
        }  
    }
}