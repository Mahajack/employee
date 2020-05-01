 using System;

class CountingDigit
{

    static int countDigit(long number)
    {
        if (number == 0)
            return 0;
        return 1 + countDigit(number / 10);
    }

    //Driver Code
    public static void Main()
    {
        Console.Write("Enter the Digit : ");
        long number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Number of "
                        + "digits : " + countDigit(number));
    }
}


