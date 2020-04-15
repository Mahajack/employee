using System;
public class Student
{
    public int rollno;
    public Double physics, maths, biology, total;
    public Double percentage;
    public String name, division;

    //getting input from user
    public void GetInputValues()
    {
        Console.Write("Enter Student Roll number :");
        rollno = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter student name :");
        name = Console.ReadLine();

        Console.Write("Enter physics mark :");
        physics = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter maths mark :");
        maths = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter biology mark :");
        biology = Convert.ToInt32(Console.ReadLine());

        //calculating the total mark
        total = physics + maths + biology;

        //calculating the student percentage
        percentage = total / 3.0;

        //checking student grade
        if (percentage >= 70)
            division = "***First class***";
        else
            if (percentage < 70 && percentage >= 50)
                division = "***Second class***";
            else
                if (percentage < 50 && percentage >= 35)
                    division = "***pass***";
                else
                    division = "***Fail***";
    }

}
public class College : Student
{
    public void Display()
    {
        Console.WriteLine("\n******Student Details******");
        Console.WriteLine("Student Roll Number : " + rollno);
        Console.WriteLine("Student Name : " + name);
        Console.WriteLine("Total mark scored by Student : {0}\nPercentage : {1}\n {2}", total, percentage, division);
    }

    //main method
    public static void Main(string[] args)
    {
        College details = new College();
        details.GetInputValues();
        details.Display();

    }
}