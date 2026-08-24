namespace _04Polymorphism;

public class Manager : Employee
{
    public decimal Bonus { get; set; }


    public Manager(decimal salary, decimal bonus) : base(salary)
    {
        Bonus = bonus;
    }


    public override void Say()
    {
        Console.WriteLine($"I am a Manager!");
    }
    
    public new void GetSalary()
    {
        Console.WriteLine($"Manager salary is {Salary}, bonus is {Bonus}, total income is {Salary + Bonus}!");
    }
}