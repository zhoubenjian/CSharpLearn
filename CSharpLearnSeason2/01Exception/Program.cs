namespace _01Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Console.WriteLine("CSharpLearn2: 01Exception");

                {
                    int[] intArray = { 1, 2, 3, 4 };

                    try
                    {
                        int temp = intArray[2];
                    }
                    catch (IndexOutOfRangeException e)
                    {
                        Console.WriteLine("数组下标越界...");
                    } 
                    catch (FieldAccessException e)
                    {
                        Console.WriteLine("出现FieldAccessException异常...");
                    } 
                    finally
                    {
                        Console.WriteLine("不管是否出现异常，都会继续执行");
                    }
                    Console.WriteLine("1234");
                }

                Console.WriteLine("--------------------------");

                {
                    int n1 = 0;
                    int n2 = 0;

                    while (true)
                    {
                        try
                        {
                            n1 = Convert.ToInt32(Console.ReadLine());
                            n2 = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("你输入的数字有误！");
                        }
                    }
                    Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
                }
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
