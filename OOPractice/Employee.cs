using System;
namespace OOPractice
{
  public class Employee : Person
  {
    public string position;
    int pay;
    string status = "Active";
    int hoursThisWeek = 0;
    int shiftStart;

    public Employee(
      string job,
      int pay,
      string first,
      string last,
      int age
    ) :
    base(first, last, age)
    {
      position = job;
      this.pay = pay;
    }

    public int GetPay() {
      return pay;
    }

    public void GetRaise(int raise) {
      pay += raise;
    }

    public string GetStatus() {
      return status;
    }

    public void TerminateEmployee() {
      status = "Terminated";
    }

    public void Resign() {
      status = "Resigned";
    }

    public void clockIn(int start) {
      if (shiftStart != 0) throw new ArgumentException("Employee is already clocked in.");
      shiftStart = start;
    }

    public void clockOut(int end) {
      if (shiftStart == 0) throw new ArgumentException("Employee did not clock in.");
      hoursThisWeek += end - shiftStart;
    }



  }
}
