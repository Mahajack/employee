using System;
using System.Collections.Generic;
public class MinimumDistance
{
    // function to find Distance between 
    // two closest minimum 
    static int findClosestMin(int[] arr, int num)
    {
        int minimum = int.MaxValue;

        // find the minimum element in the array 
        for (int i = 0; i < num; i++)
        {
            if (arr[i] < minimum)
            {
                minimum = arr[i];
            }
        }

        // vector to store indexes of occurrences 
        // of minimum element in the array 
        List<int> indexes = new List<int>();

        // store indexes of occurrences 
        // of minimum element in the array 
        for (int i = 0; i < num; i++)
        {
            if (arr[i] == minimum)
            {
                indexes.Add(i);
            }
        }

        // if minimum element doesnot occurs atleast 
        // two times, return -1. 
        if (indexes.Count < 2)
        {
            return -1;
        }
        int minimum_distance = int.MaxValue;

        // calculate minimum difference between 
        // any two consecutive indexes 
        for (int i = 1; i < indexes.Count; i++)
        {
            if ((indexes[i] - indexes[i - 1]) < minimum_distance)
            {
                minimum_distance = (indexes[i] - indexes[i - 1]);
            }
        }

        return minimum_distance;
    }

    // Main Method
    public static void Main()
    {
        int[] arr = { 5, 1, 2, 3, 4, 1, 2, 1 };
        int size = arr.Length;
        Console.WriteLine("Minimum Distance is " +findClosestMin(arr, size));
    }
}


