namespace _04Polymorphism;

public class Employee
{
    public decimal Salary { get; set; }


    public Employee(decimal salary)
    {
        Salary = salary;
    }


    public virtual void Say()
    {
        Console.WriteLine($"I am a Employee.");
    }

    public void GetSalary()
    {
        Console.WriteLine($"Employee salary is {Salary}.");
    }
}