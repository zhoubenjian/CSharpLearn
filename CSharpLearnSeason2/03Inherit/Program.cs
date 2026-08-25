namespace _03Inherit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- CSharpLearn2: 03Inherit ---");

            Tabletop tabletop = new Tabletop(4.5, 7.5);
            tabletop.Display();


            Console.ReadKey(true);
        }
    }
}
