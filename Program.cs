using System;

public class Anagram
{

    static int NO_OF_CHARS = 256;

    /* function to check whether two strings 
    are anagram of each other */
    static bool areAnagram(char[] str1, char[] str2)
    {
        // Create 2 count arrays and initialize 
        // all values as 0 
        int[] count1 = new int[NO_OF_CHARS];
        int[] count2 = new int[NO_OF_CHARS];
        int num;

        // For each character in input strings, 
        // increment count in the corresponding 
        // count array 
        for (num = 0; num < str1.Length && num < str2.Length;
            num++)
        {
            count1[str1[num]]++;
            count2[str2[num]]++;
        }

        // If both strings are of different length. 
        // Removing this condition will make the program 
        // fail for strings like "aaca" and "aca" 
        if (str1.Length != str2.Length)
            return false;

        // Compare count arrays 
        for (num = 0; num < NO_OF_CHARS; num++)
            if (count1[num] != count2[num])
                return false;

        return true;
    }

    /* Driver program to test to print printDups*/
    public static void Main()
    {
        char[] str1 = ("csharp").ToCharArray();
        char[] str2 = ("sharpc").ToCharArray();

        if (areAnagram(str1, str2))
            Console.WriteLine("The two strings are"
                            + "anagram of each other");
        else
            Console.WriteLine("The two strings are not"
                            + " anagram of each other");
    }
}


