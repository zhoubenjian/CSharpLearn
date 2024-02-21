namespace _11Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Console.WriteLine("Season1: 11Delegate\n");

                #region 普通方法
                {
                    Console.WriteLine(Multiply(2.3, 2));
                    Console.WriteLine(Divide(4.5, 3));
                }
                #endregion

                Console.WriteLine("---------------------");

                #region 委托
                {
                    MyDelete delegate1 = Multiply;
                    Console.WriteLine(delegate1(3.14, 9));

                    MyDelete delegate2 = Divide;
                    Console.WriteLine(delegate2(19.2, 9.6));

                    NoReturnNoParam delegate3 = Test;
                    delegate3();
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
        /// 乘法
        /// </summary>
        /// <param name="param1"></param>
        /// <param name="param2"></param>
        /// <returns></returns>
        static double Multiply(double param1, double param2)
        {
            return param1 * param2;
        }

        /// <summary>
        /// 除法
        /// </summary>
        /// <param name="param1"></param>
        /// <param name="param2"></param>
        /// <returns></returns>
        static double Divide(double param1, double param2)
        {
            return (param1 / param2);
        }

        static void Test()
        {
            Console.WriteLine($"Test");
        }



        /// <summary>
        /// 委托
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        delegate double MyDelete(double p1, double p2);

        delegate void NoReturnNoParam();
    }
}
