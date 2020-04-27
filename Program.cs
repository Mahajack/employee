using System;
class Pangrams
{
    // Returns true if the string 
    // is pangram else false 
    public static bool checkPangram(string str)
    {

        // Create a hash table to mark the 
        // characters present in the string 
        // By default all the elements of 
        // mark would be false. 
        bool[] mark = new bool[26];

        // For indexing in mark[] 
        int index = 0;

        //Transverse the all character 
        for (int character = 0; character < str.Length; character++)
        {
            // If uppercase character, subtract 'A' 
            // to find index. 
            if ('A' <= str[character] && str[character] <= 'Z')
                index = str[character] - 'A';

            // If lowercase character, 
            // subtract 'a' to find 
            // index. 
            else if ('a' <= str[character] && str[character] <= 'z')
                index = str[character] - 'a';

            // If this character is other than english 
            // lowercase and uppercase characters. 
            else
                continue;

            mark[index] = true;
        }

        // Return false if any 
        // character is unmarked 
        for (int character = 0; character <= 25; character++)
            if (mark[character] == false)
                return (false);

        // If all characters 
        // were present 
        return (true);
    }

    // Driver Code 
    public static void Main()
    {
        Console.Write("Enter the Sentence : ");
        string str = Console.ReadLine();

        if (checkPangram(str) == true)
            Console.WriteLine(str + " is a pangram.");
        else
            Console.WriteLine(str + " is not a pangram.");
    }
}

