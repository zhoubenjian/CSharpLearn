namespace _02Class;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- CSharpLearn2: 02Class ---");

        #region Vector3
        {
            Vector3 vector = new Vector3();
            vector.X = 3f;
            vector.Y = 4f;
            vector.Z = 5f;
            Console.WriteLine(vector.Distance());
        }
        #endregion

        Console.WriteLine("-------------------");

        #region Vehicle
        {
            Vehicle bwm = new Vehicle("BMW", 100.0f, 229.0f, 1823.0f);
            bwm.Run();
            bwm.Stop();
        }
        #endregion
    }
}