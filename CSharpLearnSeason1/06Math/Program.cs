namespace _06Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Season1: 06Math\n");

                #region N次方 / 开N次方根
                {
                    Console.WriteLine($"2^10 = {Math.Pow(2, 10)}");
                    Console.WriteLine($"10^2 = {Math.Pow(10, 2)}");

                    Console.WriteLine("{0}的平方根等于{1}", 2, Math.Pow(2, 1 / 2.0));
                    Console.WriteLine("{0}的平方根等于{1}", 3, Math.Pow(3, 1 / 2.0));
                    Console.WriteLine("{0}的平方根等于{1}", 5, Math.Pow(5, 1 / 2.0));
                }
                #endregion

                Console.WriteLine("-----------------------------");

                #region 对数
                {
                    Console.WriteLine($"log2 8 = {Math.Log2(8)}");
                    Console.WriteLine($"lg10000 = {Math.Log10(9999)}");
                    Console.WriteLine($"lne^4 = {Math.Log(Math.Pow(Math.E, 4), Math.E)}");
                }
                #endregion

                Console.WriteLine("-----------------------------");

                #region 三角函数(弧度)
                {
                    Console.WriteLine("sin{0} = {1}", "(4π/9)", Math.Sin(4 * Math.PI / 9));
                    Console.WriteLine("cos{0} = {1}", "(4π/9)", Math.Cos(4 * Math.PI / 9));
                    Console.WriteLine("tan{0} = {1}", "(4π/9)", Math.Tan(4 * Math.PI / 9));
                }
                #endregion
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
