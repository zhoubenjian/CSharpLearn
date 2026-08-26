namespace _06Event;

public class Boiler
{
    public int Temperature { get; set; }
    public int Pressure { get; set; }


    public Boiler(int temperature, int pressure)
    {
        Temperature = temperature;
        Pressure = pressure;
    }
}