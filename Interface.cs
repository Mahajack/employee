using System;

public interface IShape
{
    void circle(); 
}
   public class Triangle : IShape
    {
        public void circle()
        {
            Console.WriteLine("Draw the circle");
        }

    }

   public class Rectangle : IShape
    {
        public void circle()
        {
            Console.WriteLine("Draw the Rectangle shape");
        }
    }

public class Structure
{
 static void Main(string[] args)
 {
     IShape draw;
     draw = new Triangle();
     draw.circle();

     draw = new Rectangle();
     draw.circle();
 }
}

