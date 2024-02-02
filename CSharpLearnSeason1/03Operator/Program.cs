namespace _03Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Console.WriteLine("Season1: 03Operator\n");

                #region 常规运算符
                {
                    int a = 10, b = 2;
                    Console.WriteLine($"{a} + {b} = {a + b}");              // 12
                    Console.WriteLine("{0} - {1} = {2}", a, b, (a - b));    // 8
                    Console.WriteLine("{0} * {1} = {2}", a, b, (a * b));    // 20
                    Console.WriteLine($"{a} / {b} = {a / b}");              // 5

                    Console.WriteLine(13 % 7);    // 6
                }
                #endregion

                Console.WriteLine($"\n---------------------------------------------\n");

                #region 自增自减
                {
                    int a = 1;
                    Console.WriteLine(a++); // 2
                    Console.WriteLine(++a); // 2

                    int b = 1, c = 1;
                    // 先赋值，再自增
                    int b1 = b++;   
                    // 先自增，再赋值
                    int c1 = ++c;
                    Console.WriteLine("b1={0}; c1 = {1}", b1, c1);  // b1=1; c1=2
                }
                #endregion

                Console.WriteLine($"\n---------------------------------------------\n");

                #region 常用运算符
                {
                    bool a = true;
                    bool b = false;
                    Console.WriteLine($"a={a}; b={b}"); // a=True; b=False

                    Console.WriteLine((10 > 9) && (3 > 4));     // False
                    Console.WriteLine((10 > 9) || (3 > 4));     // True
                    Console.WriteLine(!(4 < 7));                // False
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
