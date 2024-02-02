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
            }
            catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
