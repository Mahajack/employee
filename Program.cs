using System;

class TimeInWords
{

    static void printWords(int hour, int minute)
    {
        string[] nums = { "zero", "one", "two", "three", "four", 
							"five", "six", "seven", "eight", "nine" , 
							"ten", "eleven", "twelve", "thirteen", 
							"fourteen", "fifteen", "sixteen", "seventeen", 
							"eighteen", "nineteen", "twenty", "twenty one", 
							"twenty two", "twenty three", "twenty four", 
							"twenty five", "twenty six", "twenty seven", 
							"twenty eight", "twenty nine", 
						};

        if (minute == 0)
            Console.WriteLine(nums[hour] + " o' clock ");

        else if (minute == 1)
            Console.WriteLine("one minute past " + nums[hour]);                       

        else if (minute == 59)
            Console.WriteLine("one minute to " +
                                nums[(hour % 12) + 1]);

        else if (minute == 15)
            Console.WriteLine("quarter past " + nums[hour]);

        else if (minute == 30) 
            Console.WriteLine("half past " + nums[hour]);

        else if (minute == 45)
            Console.WriteLine("quarter to " +
                                nums[(hour % 12) + 1]);

        else if (minute <= 30)
            Console.WriteLine(nums[minute] + " minutes past " +
                                                    nums[hour]);

        else if (minute > 30)
            Console.WriteLine(nums[60 - minute] + " minutes to " +
                                            nums[(hour % 12) + 1]);
    }

    // Driven code 
    public static void Main()
    {
        Console.Write("Enter the hour and minute : ");
        int hour = Convert.ToInt32(Console.ReadLine());
        int minute = Convert.ToInt32(Console.ReadLine());
        printWords(hour, minute);
    }
}

