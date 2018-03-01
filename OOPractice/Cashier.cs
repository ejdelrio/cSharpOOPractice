using System;
namespace OOPractice
{
  public class Cashier : Employee
  {
    
    public Cashier(string first, string last, int age):
    base("Cashier", 15, first, last, age)
    {
    }
  }
}
