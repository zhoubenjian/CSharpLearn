namespace _05OperatorOverload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- CSharpLearn2: 05OperatorOverload ---");


            #region 运算符(+)重载
            {
                Box box1 = new Box(6.0, 7.0, 5.0);
                Console.WriteLine($"box1的体积：{box1.Volume()}");

                Box box2 = new Box(12.0, 13.0, 10.0);
                Console.WriteLine($"box2的体积：{box2.Volume()}");


                // 使用重载的运算符(+)将两个Box对象相加
                Box box3 = box1 + box2;
                Console.WriteLine("\nbox3的体积：{0}", box3.Volume());
            }
            #endregion


            Console.ReadKey(true);
        }
    }
}
