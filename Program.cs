using System;
namespace Steps
{
    class StairCase
    {
        // Modified Binary search function 
        // to solve the equation 
        public static int solve(int low, int high, int num)
        {
            while (low <= high)
            {
                int mid = (low + high) / 2;

                // if mid is solution to equation 
                if ((mid * (mid + 1)) == num)
                    return mid;

                // if our solution to equation 
                // lies between mid and mid-1 
                if (mid > 0 && (mid * (mid + 1)) > num &&
                            (mid * (mid - 1)) <= num)
                    return mid - 1;

                // if solution to equation is 
                // greater than mid 
                if ((mid * (mid + 1)) > num)
                    high = mid - 1;

                // if solution to equation is less 
                // than mid 
                else
                    low = mid + 1;
            }
            return -1;
        }

        // Driver function 
        public static void Main()
        {
            Console.Write("Enter the Number of bricks : ");
            int num = Convert.ToInt32(Console.ReadLine());
            // call binary search method to 
            // solve for limits 1 to num 
            int steps = solve(1, num, 2 * num);

            // Because our pattern starts 
            //from 2, 3, 4, 5... 
            // so, we subtract 1 from ans 
            if (steps != -1)
                steps--;
            Console.WriteLine("Number of stair steps = " + steps);
        }
    }
}

