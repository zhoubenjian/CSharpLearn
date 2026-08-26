namespace _06Event;

public class DelegateBoilerEvent
{
    public delegate void BoilerLogHandler(string status);
    
    // 基于以上委托定义事件
    public event BoilerLogHandler BoilerEventLog;
        
    
    public void LogProcess()
    {
        string remarks = "O.K.";
        Boiler boiler = new Boiler(100, 12);
        int temperature = boiler.Temperature;
        int pressure = boiler.Pressure;

        if (temperature > 150 || temperature < 80 || pressure < 12 || pressure > 15)
        {
            remarks = "Need Maintenance";
        }
        
        OnBoilerEventLog($"Logging Info: \nTemperature: {temperature}\nPressure: {pressure}\nMessage: {remarks}");
    }

    protected void OnBoilerEventLog(string status)
    {
        BoilerEventLog?.Invoke(status);
    }
}