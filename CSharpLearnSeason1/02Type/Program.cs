namespace _02Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Season1: 02Type\n");

                #region 字符类型
                {
                    char a = 'a';
                    Console.WriteLine(a);
                    int aValue = a;
                    Console.WriteLine(aValue);  // 97 ('a')

                    char space = ' ';
                    int spaceValue = space;
                    Console.WriteLine(spaceValue);  // 32 (' ')

                    int value = 65;
                    // 强制类型转换
                    char c = (char)value;
                    Console.WriteLine(c);   // A (65)

                    char b = '1';
                    int bValue = b;
                    Console.WriteLine(b);       // 1
                    Console.WriteLine(bValue);  // 49

                    // 忽略字符串中的转义字符
                    Console.WriteLine(@"\n\t\\'"); // \n\t\\'

                    // @ + 字符串，可换行
                    string str1 = @"Linux is not Unix
                        -- Linus Benedict Torvalds.";
                    /*
                     Linux is not Unix
                        -- Linus Benedict Torvalds.
                     */
                    Console.WriteLine(str1);
                }
                #endregion

                Console.WriteLine($"\n---------------------------------------------\n");

                #region 数值类型
                {
                    Console.WriteLine($"MaxByteValue:{byte.MaxValue}"); // 255
                    Console.WriteLine($"MinByteValue:{byte.MinValue}"); // 0

                    Console.WriteLine($"MaxShortValue:{short.MaxValue}");   // 32767
                    Console.WriteLine($"MinShortValue:{short.MinValue}");   // -32768

                    Console.WriteLine($"MaxIntValue:{int.MaxValue}");   // 2147483647
                    Console.WriteLine($"MinIntValue:{int.MinValue}");   //-2147483648

                    Console.WriteLine($"MaxLongValue:{long.MaxValue}"); // 9223372036854775807
                    Console.WriteLine($"MinLongValue:{long.MinValue}"); // -9223372036854775808

                    Console.WriteLine($"MaxFloatValue:{float.MaxValue}");   // 3.4028235E+38
                    Console.WriteLine($"MinFloatValue:{float.MinValue}");   // -3.4028235E+38
                }
                #endregion

                Console.WriteLine($"\n---------------------------------------------\n");

                //#region string转int
                //{
                //    int input = Convert.ToInt32(Console.ReadLine());
                //    Console.WriteLine(input);
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
