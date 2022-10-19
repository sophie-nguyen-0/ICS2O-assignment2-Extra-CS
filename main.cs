using System;

class Program
{
    public static void Main(string[] args)
    {
          int sideA;
          int sideB;
          int sideC;
          int perimeter;

          Console.WriteLine("calculates perimeter of a triangle.");
          Console.WriteLine("");

          Console.Write("Enter side a (cm): ");
          sideA = Convert.ToInt32(Console.ReadLine());
          Console.Write("Enter side b (cm): ");
          sideB = Convert.ToInt32(Console.ReadLine());
          Console.Write("Enter side c (cm): ");
          sideC = Convert.ToInt32(Console.ReadLine());

          perimeter = (sideA + sideB + sideC);

          Console.WriteLine("");
          Console.WriteLine("perimeter is: " + perimeter + " cm. ");

          Console.WriteLine("\nDone.");
  }
}