using System;
using System.Collections;

//interface 1
interface Institute
{
    void languages();
}

//parent class 1
class Student1: Institute
{
    public void languages()
    {
        ArrayList mylist = new ArrayList();

        mylist.Add("C Sharp");
        mylist.Add("Python");
        mylist.Add("Java");
        mylist.Add("SQL");
        
        Console.WriteLine("\nLanguages provided by Institute : ");
        foreach(var list in mylist)
        {
            Console.WriteLine(">>>" +list);
        }
    }

}

//interface 2
interface Institute2
{
    void courses();
}

//parent class 2
class Student2 : Institute2
{
    public void courses()
    {
        ArrayList mylist = new ArrayList();

        mylist.Add("Java Course");
        mylist.Add("Oracle");
        mylist.Add("UI Design");
        mylist.Add("Embedded");
        
        Console.WriteLine("\nCourse provided by Institute2 :");
        foreach(var list in mylist)
        {
            Console.WriteLine(">>>" +list);
        }
    }

}

//child class
class Success : Institute,Institute2
{
    Student1 myobj1 = new Student1();
    Student2 myobj2 = new Student2();

    public void languages()
    {
        myobj1.languages();
    }
    public void courses()
    {
        myobj2.courses();
    }
}

//main method
//driver class
public class Education
{
    public static void Main(string[] args)
    {
        Success obj = new Success();
        obj.languages();
        obj.courses();
    }
}
