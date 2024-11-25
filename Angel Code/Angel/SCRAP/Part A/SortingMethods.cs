﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Testing_for_R_T
{
    public class SortingMethods
    {
        public static void quickSort(int[] arr, int low, int high)
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
                quickSort(arr, low, j);
            if (high > i)
                quickSort(arr, i, high);
        }
        public static void bubbleSort(int[] arr)
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
