namespace _09Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Console.WriteLine("Season1: 09Recursion\n");

                #region 斐波那契数组
                {
                    Console.WriteLine(Fib(1));  // 1
                    Console.WriteLine(Fib(2));  // 1
                    Console.WriteLine(Fib(3));  // 2
                    Console.WriteLine(Fib(4));  // 3
                    Console.WriteLine(Fib(5));  // 5
                    Console.WriteLine(Fib(6));  // 8
                    Console.WriteLine(Fib(7));  // 13
                    Console.WriteLine(Fib(8));  // 21
                    Console.WriteLine(Fib(9));  // 34
                    Console.WriteLine(Fib(10)); // 55
                }
                #endregion

                Console.WriteLine("------------------------");

                #region 阶乘
                {
                    Console.WriteLine(Factorial(0));    // 1
                    Console.WriteLine(Factorial(1));    // 1
                    Console.WriteLine(Factorial(2));    // 2
                    Console.WriteLine(Factorial(3));    // 6
                    Console.WriteLine(Factorial(4));    // 24
                    Console.WriteLine(Factorial(5));    // 120
                }
                #endregion

                Console.WriteLine("------------------------");

                #region 阶乘累加
                {
                    Console.WriteLine(FactorialAdd(5));
                }
                #endregion
            }
            catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }



        /// <summary>
        /// 斐波那契数
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static long Fib(int n)
        {
            if (n == 1 || n == 2)
                return 1;
            return Fib(n - 1) + Fib(n - 2);
        }

        /// <summary>
        /// 阶乘
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static long Factorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            return Factorial(n - 1) * n;
        }

        /// <summary>
        /// 阶乘累加
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static long FactorialAdd(int n)
        {
            long sum = 0;
            for (int i = n; i >= 1; i--)
                sum += Factorial(i);
            return sum;
        }
    }
}
