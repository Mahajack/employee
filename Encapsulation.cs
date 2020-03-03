using System;

public class Encap
{
    private string studentname;
    private int studentage;

    public string Name
    {
        get {return studentname;}
        set {studentname = value;}

    }
     public int Age
     {
         get {return studentage;}
         set {studentage = value;}
     }

class student
{
    public static void Main(string[] args){
    Encap myobj = new Encap();

    myobj.Name = "Maha";
    myobj.Age = 22;

    Console.WriteLine("Student Name is " +myobj.Name);
    Console.WriteLine("Student Age is " +myobj.Age);

}
}
}