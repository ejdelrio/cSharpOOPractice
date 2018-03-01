using System;
namespace OOPractice
{
  public class Person
  {
    public string first;
    public string last;
    public int age;

    public int height;
    public int weight;
    string sex;
    string gender;




    public Person(string first, string last, int age)
    {
      this.first = first;
      this.last = last;
      this.age = age;
    }

    public void Greet() {
      Console.Write(string.Format("Hello my name is {0} {1}", first, last));
    }

    public string GetGender() {
      return gender;
    }

    public void SetSex(string sex) {
      this.sex = sex;
    }

    public string GetSex() {
      return sex;
    }

    public void SetGender(string gen) {
      gender = gen;
    }

  }
}
