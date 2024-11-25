using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angel_Code.Angel
{
    public class Part_B_Full
    {
        public static void Part_B_BubbleSort()
        {
            Console.WriteLine("********** Section 1 – Bubble Sort ********** \n");
            int[] studentGrades = { 65, 95, 75, 55, 56, 90, 98, 88, 97, 78 };
            Console.WriteLine("Unsorted list of Grades: ");
            printArray(studentGrades);
            Console.WriteLine();
            sortArrayDescBS(studentGrades);
            Console.WriteLine("The grades in decending order are: ");
            printArray(studentGrades);
            Console.WriteLine();
            sortArrayAscBS(studentGrades);
            Console.WriteLine("The grades in ascending order are: ");
            printArray(studentGrades);
            Console.WriteLine();
        }
        public static void Part_B_QuickSort()
        {
            Console.WriteLine("********** Section 2 – Quick Sort ********** \n");
            int[] studentGrades = { 65, 95, 75, 55, 56, 90, 98, 88, 97, 78 };
            int low = 0;
            int high = studentGrades.Length - 1;
            Console.WriteLine("Unsorted list of Grades: ");
            printArray(studentGrades);
            Console.WriteLine();
            sortArrayDescQS(studentGrades, low, high);
            Console.WriteLine("The grades in decending order are: ");
            printArray(studentGrades);
            Console.WriteLine();
            sortArrayAscQS(studentGrades, low, high);
            Console.WriteLine("The grades in ascending order are: ");
            printArray(studentGrades);
            Console.WriteLine();
        }
        public static void Part_B_SequentialSearch()
        {
            Console.WriteLine("********** Section 3 – Sequential Search ********** \n");
            int[] studentGrades = { 65, 95, 75, 55, 56, 90, 98, 88, 97, 78 };
            string returnMessage = null;
            sortArrayAscBS(studentGrades);
            returnMessage = sequentialSearch(studentGrades, 75);
            Console.WriteLine("The contents of the grade array are: ");
            printArray(studentGrades);
            Console.WriteLine();
            Console.WriteLine(returnMessage);
            returnMessage = sequentialSearch(studentGrades, 60);
            Console.WriteLine();
            Console.WriteLine(returnMessage);
            Console.WriteLine();
        }
        public static void Part_B_BinarySearch()
        {
            Console.WriteLine("********** Section 4 – Binary Search ********** \n");
            int[] studentGrades = { 65, 95, 75, 55, 56, 90, 98, 88, 97, 78 };
            string returnMessage = null;
            sortArrayAscBS(studentGrades);
            returnMessage = binarySearch(studentGrades, 56);
            Console.WriteLine("The contents of the grade array are: ");
            printArray(studentGrades);
            Console.WriteLine();
            Console.WriteLine(returnMessage);
            returnMessage = sequentialSearch(studentGrades, 50);
            Console.WriteLine();
            Console.WriteLine(returnMessage);
            Console.WriteLine();
        }

        //--------------------------METHODS-------------------------------------------------
        public static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }
        public static void sortArrayDescBS(int[] arr)
        {
            int t;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] < arr[i + 1])
                    {
                        t = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = t;
                    }
                }
            }
        }
        public static void sortArrayAscBS(int[] arr)
        {
            int t;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        t = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = t;
                    }
                }
            }
        }
        public static void sortArrayDescQS(int[] arr, int low, int high)
        {
            if (arr == null || arr.Length == 0)
                return;
            if (low >= high)
                return;
            // pick the pivot
            int middle = low + (high - low) / 2;
            int pivot = arr[middle];
            // make left < pivot and right > pivot
            int i = low, j = high;
            while (i <= j)
            {
                while (arr[i] > pivot)
                {
                    i++;
                }
                while (arr[j] < pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            }
            // recursively sort two sub parts
            if (low < j)
                sortArrayDescQS(arr, low, j);
            if (high > i)
                sortArrayDescQS(arr, i, high);
        }
        public static void sortArrayAscQS(int[] arr, int low, int high)
        {
            if (arr == null || arr.Length == 0)
                return;
            if (low >= high)
                return;
            // pick the pivot
            int middle = low + (high - low) / 2;
            int pivot = arr[middle];
            // make left < pivot and right > pivot
            int i = low, j = high;
            while (i <= j)
            {
                while (arr[i] < pivot)
                {
                    i++;
                }
                while (arr[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            }
            // recursively sort two sub parts
            if (low < j)
                sortArrayAscQS(arr, low, j);
            if (high > i)
                sortArrayAscQS(arr, i, high);
        }
        public static string sequentialSearch(int[] arr, int num)
        {
            string answer = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    answer = num + " found at positon " + (i + 1);
                    return answer;
                }
            }
            answer = num + " is not present in the array";
            return answer;
        }
        public static string binarySearch(int[] arr, int num)
        {
            string answer = "";
            int first = 0;
            int last = arr.Length - 1;
            int middle = (first + last) / 2;
            while (first <= last)
            {
                if (arr[middle] < num)
                    first = middle + 1;
                else if (arr[middle] == num)
                {
                    answer = num + " found at location " + (middle + 1) + ".";
                    break;
                }
                else
                    last = middle - 1;
                middle = (first + last) / 2;
            }
            if (first > last)
                answer = num + " is not present in the list.\n";
            return answer;
        }
    }
}
