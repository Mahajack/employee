using System;

class JumpingOnTheClouds
{
    // Returns minimum number of 
    // jumps to reach arr[high] from arr[len] 
    static int minJumps(int[] arr, int len, int high)
    {
        // Base case: when source 
        // and destination are same 
        if (high == len)
            return 0;

        // When nothing is reachable 
        // from the given source 
        if (arr[len] == 0) 
            return int.MaxValue;

        // Traverse through all the points 
        // reachable from arr[len]. Recursively 
        // get the minimum number of jumps 
        // needed to reach arr[high] from these 
        // reachable points. 
        int min = int.MaxValue;
        for (int num = len + 1; num <= high && num <= len + arr[len]; num++)
        {
            int jumps = minJumps(arr, num, high);
            if (jumps != int.MaxValue && jumps + 1 < min)
                min = jumps + 1;
        }
        return min;
    }

    // Driver code 
    public static void Main()
    {
        int[] arr = { 1, 3, 6, 3, 2, 3, 6, 8, 9, 5 };
        int input = arr.Length;
        Console.WriteLine("Minimum number of jumps to reach end is "
                    + minJumps(arr, 0, input - 1));
    }
}

