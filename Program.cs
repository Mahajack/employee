using System;

public class GameOfStone
{
    // Function that returns true if u win 
    static bool checkWin(int noofstone)
    {
        if (noofstone % 2 != 0)
            return true;
        return false;
    }

    // Driver code 

    static public void Main()
    {

        Console.Write("Enter the No of Stone : ");
        int noofstone = Convert.ToInt32(Console.ReadLine());

        if (checkWin(noofstone))
            Console.WriteLine("Yes!You won");
        else
            Console.WriteLine("NO!You lose");

    }

}
