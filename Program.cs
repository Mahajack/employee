using System;

class Triplets
{
    // returns true if there is 
    // triplet with sum equal 
    // to 'sum' present in input[]. 
    // Also, prints the triplet 
    static bool find3Numbers(int[] input, int arr_size, int sum)
                           
    {
        // Fix the first 
        // element as input[i] 
        for (int firstelement = 0; firstelement < arr_size - 2; firstelement++)
        {

            // Fix the second 
            // element as input[j] 
            for (int secondelement = firstelement + 1;secondelement < arr_size - 1; secondelement++)
            {

                // the third number 
                for (int thirdelement = secondelement + 1;thirdelement < arr_size; thirdelement++)
                {
                    if (input[firstelement] + input[secondelement] + input[thirdelement] == sum)
                    {
                        Console.WriteLine("Triplet is " + input[firstelement] + ", " + input[secondelement] + ", " + input[thirdelement]);
                        return true;
                    }
                }
            }
        }

        return false;
    }

    // Driver Code 
    public static void Main()
    {
        int[] input = { 1, 4, 45, 6, 10, 8 };
        int sum = 11;
       
        int arr_size = input.Length;

        find3Numbers(input, arr_size, sum);
    }
}


