namespace _04Polymorphism;

class Program
{
    static void Main(string[] args)
    {
        /*
         * 1.override 看右边（实际对象类型）：这就是真正的多态。C# 运行时会去查虚方法表（V-Table），发现右边实际 new 的是子类，就会顺藤摸瓜调用子类重写后的方法。
         * 2.new 看左边（引用变量类型）：这就是静态绑定（隐藏）。C# 编译器在编译阶段就已经根据左边的类型决定了调用哪个方法，运行时根本不去关心右边实际是什么对象。
         */
        Console.WriteLine("--- 04Polymorphism ---");
        
        {
            Employee employee = new Employee(1999.00M);
            employee.Say();         // I am a Employee.
            employee.GetSalary();   // Employee salary is 1999.00.
        }
        
        
        Console.WriteLine("\n---------------------------------------\n");

        
        #region 父类引用 -> 子类对象
        {
            Employee employee = new Manager(2999.00m, 1000.00m);
            // 调用子类方法
            employee.Say();         // I am a Manager!
            // 调用父类方法
            employee.GetSalary();   // Employee salary is 2999.00.
        }
        #endregion
        
        
        Console.WriteLine("\n---------------------------------------\n");

        
        {
            Manager manager = new Manager(3999.00m, 1999.00m);
            manager.Say();          // I am a Manager!
            manager.GetSalary();    // Manager salary is 3999.00, bonus is 1999.00, total income is 5998.00!
        }
    }
}