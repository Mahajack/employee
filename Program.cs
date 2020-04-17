using System;

class CamelCase
{
    // Function to find the count of words 
    // in a CamelCase sequence 
    static int countWords(String word)
    {
        int count = 1;

        for (int i = 1; i < word.Length - 1; i++)
        {
            if (word[i] >= 65 && word[i] <= 90)
                count++;
        }

        return count;
    }

    // Main method
    public static void Main(String[] args)
    {
        String word = "geeksForGeeks";

        Console.WriteLine("The Count of Word is " +countWords(word));

    }
}


