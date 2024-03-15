namespace _02Class;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("CSharpLearn2: 02Class");
        {
            Vector3 vector = new Vector3();
            vector.X = 3f;
            vector.Y = 4f;
            vector.Z = 5f;
            Console.WriteLine(vector.Distance());
        }
    }
}