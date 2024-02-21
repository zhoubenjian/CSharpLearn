namespace _10Constant
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Console.WriteLine("Season1: 10Constant\n");

                #region 变量
                {
                    int i = 10;
                    i = 20;
                    Console.WriteLine(i);
                }
                #endregion

                Console.WriteLine("----------------------");

                #region 常量
                {
                    // 定义后无法修改
                    const double PI = 3.1415926;
                    Console.WriteLine(PI);
                }
                #endregion

                Console.WriteLine("----------------------");

                #region 枚举
                {
                    // 一月
                    Month month1 = Month.January;
                    Console.WriteLine(month1);      // January
                    // 十二月
                    Month month12 = Month.December;
                    Console.WriteLine(month12);     // December

                    int monday = (int) Week.Monday;
                    Console.WriteLine(monday);      // 0
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


    enum Month
    {
        January,

        February,

        March,

        April,

        May,

        June,

        July,

        August,

        September,

        October,

        Noverber,

        December
    }

    enum Week
    {
        Monday,

        Tuesday,

        Wednesday,

        Thursday,

        Friday,

        Saturday,

        Sunday
    }
}
