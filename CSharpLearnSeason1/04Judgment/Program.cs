namespace _04Judgment
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Console.WriteLine("Season1: 04Judgement\n");

                #region switch...case
                {
                    Console.Write($"Please input your num:");
                    var num = Convert.ToInt32(Console.ReadLine());
                    switch (num)
                    {
                        case 1:
                        case 4:
                            Console.WriteLine("Mathematics");
                            break;
                        
                        case 2:
                            Console.WriteLine("Physics");
                            break;

                        case 3:
                            Console.WriteLine("Chemistry");
                            break;

                        case 5:
                            Console.WriteLine("Biology");
                            break;

                        case 6:
                            Console.WriteLine("PE");
                            break;

                        case 7:
                            Console.WriteLine("Computer");
                            break;

                        default:
                            Console.WriteLine("Stack OverFlow!");
                            break;
                    }
                }
                #endregion

                Console.WriteLine($"\n---------------------------------------------\n");

                #region while
                {
                    int i = 1;
                    int sum = 0;
                    while (i <= 100)
                    {
                        sum += i;
                        i++;
                    }
                    Console.WriteLine("1 + 2 +...+ 99 + 100 = {0}", sum);

                    // 增长率问题
                    int origin = 80000;
                    int year = 0;
                    while (origin < 200000)
                    {
                        origin = (int)(origin * 1.25);
                        year++;
                    }
                    Console.WriteLine($"80000 => 200000，需要{year}年");

                    // (3n + 1)问题：任意大于1的整数，奇数*3+1，偶数变为原来的一半，经过有限次变换最终变为1
                    int num = Convert.ToInt32(Console.ReadLine());
                    int temp = num;
                    int count = 0;
                    while (num != 1)
                    {
                        if (num % 2 == 0)
                        {
                            num /= 2;
                        }
                        else
                        {
                            num = 3 * num + 1;
                        }
                        count++;
                    }
                    Console.WriteLine($"{temp}经过{count}次3n+1变换！");
                }
                #endregion

                Console.WriteLine($"\n---------------------------------------------\n");

                #region for循环
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.Write(i + ", ");    // 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                    }
                }
                #endregion

                Console.WriteLine($"\n---------------------------------------------\n");

                // 至少执行一次
                #region do...while
                {
                    int i = 1;
                    do
                    {
                        Console.Write(i + ", ");    // 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                        i++;
                    } while (i <= 10);
                }
                #endregion

                Console.WriteLine($"\n---------------------------------------------\n");

                #region 回文数判断
                {
                    int n = Convert.ToInt32(Console.ReadLine());
                    int temp = n;
                    int number = 0;
                    while (n != 0)
                    {
                        int i = n % 10;
                        number *= 10;
                        number += i;

                        n = n / 10;
                    }

                    if (number == temp)
                    {
                        Console.WriteLine($"{temp}是回文数！");
                    }
                    else
                    {
                        Console.WriteLine($"{temp}不是回文数！");
                    }
                }
                #endregion

                Console.WriteLine($"\n---------------------------------------------\n");

                #region 可乐兑换问题(364瓶可乐兑换，3个空瓶可兑换一瓶可乐)
                {
                    int initNum = 364;
                    int sum = initNum;

                    while (initNum > 2)
                    {
                        sum += (initNum / 3);
                        initNum = (initNum / 3) + (initNum % 3);
                    }

                    Console.WriteLine($"一共可以畅饮{sum}瓶可乐");
                }
                #endregion

                Console.WriteLine($"\n---------------------------------------------\n");

                #region 字符串加密
                {
                    Console.Write("请输入原始信息：");
                    char[] chars = Console.ReadLine().ToCharArray();
                    for (global::System.Int32 i = 0; i < chars.Length; i++)
                    {
                        if ((chars[i] >= 'a' && chars[i] <= 'z') || (chars[i] >= 'A' && chars[i] <= 'Z'))
                        {
                            chars[i] = (char)(chars[i] + 3);
                            if ((chars[i] > 'Z' && chars[i] <= 'Z' + 3) || (chars[i] > 'z' && chars[i] <= 'z' + 3))
                                chars[i] = (char)(chars[i] - 26);
                        }
                    }

                    foreach (var c in chars)
                    {
                        Console.Write($"{c}");
                    }

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
