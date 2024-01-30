namespace _01Base
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Season1: 01Base");

                #region 字符转义
                {
                    Console.WriteLine($"\"");   // "
                    Console.WriteLine($"\\\""); // \"

                    /*** 花括号({})转义 ***/
                    // 方式一：{{}}
                    Console.WriteLine(string.Format("{{\"name\": \"{0}\", \"gender\": \"{1}\", \"birthday\": \"{2}\"}}", "Karin Aizawa", "Female", "1993-12-26"));
                    // 方式二："{","}"
                    Console.WriteLine(string.Format("{0}\"name\": \"{2}\", \"gender\": \"{3}\", \"birthday\": \"{4}\"{1}", "{", "}", "Fumino Mizutori", "Female", "1996-12-12"));
                    /*** 花括号({})转义 ***/
                }
                #endregion

                Console.WriteLine($"\n---------------------------------------------\n");

                #region 占位符输出
                {
                    // 任意次幂
                    Console.WriteLine("{0}^{1} = {2}", 2, 10, Math.Pow(2, 10));             // 1024

                    // 任意次方根
                    Console.WriteLine($"{9}开{3}次方根，等于{Math.Pow(9, 1.0 / 3.0)}");     // 2.080083823051904

                    /*** 格式化输出 ***/
                    // 数字
                    Console.WriteLine(string.Format("{0:G}", 111));     // 111 (整数保持不变)
                    Console.WriteLine(string.Format("{0:g}", 199.0));   // 199 (小数舍弃小数部分)
                    Console.WriteLine(string.Format("{0:f}", 11));      // 11.00 (固定保留两位小数)
                    Console.WriteLine(string.Format("{0:F4}", 199.007));    // 199.0070 (固定保留两位小数)

                    // 百分数
                    Console.WriteLine(string.Format("{0:P}", 0.99));    // 99.00% (默认保留两位小数)
                    Console.WriteLine(string.Format("{0:P1}", 0.30));   // 30.00%

                    // 金额
                    decimal rmb = 123456.456M;
                    Console.WriteLine(string.Format("{0:C}", rmb));     // ￥123,456.46 (四舍五入，保留两位小数)
                    Console.WriteLine(string.Format("{0:C0}", rmb));    // ￥123,456 (舍弃小数部分)

                    // 指数(科学计数法)
                    Console.WriteLine(string.Format("{0:e}", 1234567890));  // 1.234568e+009

                    // 进制
                    Console.WriteLine(string.Format("{0:d}", 1024));    // 1024 (十进制)
                    Console.WriteLine(string.Format("{0:x}", 1024));    // 400 (十六进制)
                    Console.WriteLine(string.Format("{0:x}", 250));     // fa (十六进制)
                    /*** 格式化输出 ***/
                }
                #endregion

                Console.WriteLine($"\n---------------------------------------------\n");

                //#region 输入
                //{
                //    Console.Write($"请输入：");
                //    // console.Read();  返回用户从控制台上输入数据的首字符的ASCLL码
                //    var input = Console.ReadLine();     
                //    Console.WriteLine($"您刚才输入的是：{input}");
                //}
                //#endregion
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
