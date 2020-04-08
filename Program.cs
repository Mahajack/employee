using System;

class SelectionSort
{
    static void sort(int[] arr)
    {
        int input = arr.Length;

        // One by one move boundary of unsorted subarray 
        for (int first_element = 0; first_element < input - 1; first_element++)
        {
            // Find the minimum element in unsorted array 
            int min_idx = first_element;
            for (int second_element = first_element + 1; second_element < input; second_element++)
                if (arr[second_element] < arr[min_idx])
                    min_idx = second_element;

            // Swap the found minimum element with the first element
            int temp = arr[min_idx];
            arr[min_idx] = arr[first_element];
            arr[first_element] = temp;
        }
    }

    // Prints the array 
    static void printArray(int[] arr)
    {
        int input = arr.Length;
        for (int first_element = 0; first_element < input; ++first_element)
            Console.Write(arr[first_element] + " ");
        Console.WriteLine();
    }
     
    //Main Method
    public static void Main()
    {
        int[] arr = { 64, 25, 12, 22, 11 };
        sort(arr);
        Console.WriteLine("Sorted array");
        printArray(arr);
    }

}

