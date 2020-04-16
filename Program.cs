using System;

public class SumOfTwoDiagonal
{

    // Function to calculate difference 
    public static int difference(int[,] arr,
                                int input)
    {

        // Initilize sum of two diagonal
        int primary = 0, secondary = 0;

        for (int rows = 0; rows < input; rows++)
        {
            for (int column = 0; column < input; column++)
            {

                // finding sum of primary diagonal 
                if (rows == column)
                    primary += arr[rows, column];

                // finding sum of secondary diagonal 
                if (rows == input - column - 1)
                    secondary += arr[rows, column];
            }
        }

        // Absolute difference of the 
        // sums across the diagonals 
        return Math.Abs(primary - secondary);
    }

    // Driver Code 
    public static void Main()
    {
        int input = 3;

        int[,] arr ={{11, 2, 4}, 
					{4 , 5, 6}, 
					{10, 8, -12}};

        Console.WriteLine("The Sum of Two Diagonal is : " +difference(arr, input));

    }
}

