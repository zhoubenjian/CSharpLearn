namespace _06Event;

public class BoilerInfoLogger : IDisposable
{
    private readonly StreamWriter _streamWriter;

    public BoilerInfoLogger(string filename)
    {
        _streamWriter = new StreamWriter(new FileStream(filename, FileMode.Append, FileAccess.Write));
    }

    
    public void Logger(string info)
    {
        _streamWriter.WriteLine(info);
    }

    public void Dispose()
    {
        _streamWriter?.Close();
    }    
}