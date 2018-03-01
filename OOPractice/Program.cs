using System;

namespace OOPractice
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      Employee first = new Employee("Cashier", 15, "John", "Doe", 19);
      first.Greet();
    }
  }
}
