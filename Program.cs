using System;

class BubbleSort
{
    static void bubbleSort(int[] arr)
    {
        int input = arr.Length;
        for (int firstelement = 0; firstelement < input - 1; firstelement++)
            for (int secondelement = 0; secondelement < input - firstelement - 1; secondelement++)
                if (arr[secondelement] > arr[secondelement + 1])
                {
                    // swap temp and arr[i] 
                    int temp = arr[secondelement];
                    arr[secondelement] = arr[secondelement + 1];
                    arr[secondelement + 1] = temp;
                }
    }

    /* Prints the array */
    static void printArray(int[] arr)
    {
        int input = arr.Length;
        for (int firstelement = 0; firstelement < input; ++firstelement)
            Console.Write(arr[firstelement] + " ");
        Console.WriteLine();
    }

    // Driver method 
    public static void Main()
    {
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
        bubbleSort(arr);
        Console.WriteLine("Sorted array");
        printArray(arr);
    }

}
