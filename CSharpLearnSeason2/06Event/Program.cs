namespace _06Event;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- CSharpLearn2: 06Event ---");
        
        BoilerInfoLogger fileLogger = new BoilerInfoLogger("./boiler.txt");
        DelegateBoilerEvent boilerEvent = new DelegateBoilerEvent();
        boilerEvent.BoilerEventLog += Logger;
        boilerEvent.BoilerEventLog += fileLogger.Logger;
        boilerEvent.LogProcess();
        
        Console.ReadKey(true);
    }
    
    static void Logger(string info)
    {
        Console.WriteLine(info);
    }
}