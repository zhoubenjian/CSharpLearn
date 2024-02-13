namespace _05Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Season1: 05Array\n");

                int[] nums = { 2, 3, 5, 7, 11, 13, 17, 19 };

                #region 遍历
                {
                    // fori遍历
                    for (int i = 0; i < nums.Length; i++)
                    {
                        Console.Write($"{nums[i]}, ");
                    }

                    Console.WriteLine();

                    // foreach遍历(禁止修改值)
                    foreach (var item in nums)
                    {
                        Console.Write("{0}, ", item);
                    }
                }
                #endregion

                Console.WriteLine($"\n---------------");

                #region 最小值
                {
                    string input = Console.ReadLine();
                    string[] strArray = input.Split(" ");
                    int[] intArray = new int[strArray.Length];
                    for (global::System.Int32 i = 0; i < intArray.Length; i++)
                        intArray[i] = Convert.ToInt32(strArray[i]);

                    int minValue = intArray[0];
                    for (global::System.Int32 i = 1; i < intArray.Length; i++)
                        minValue = (intArray[i] < minValue) ? intArray[i] : minValue;

                    Console.WriteLine($"最小值：" + minValue);
                }
                #endregion

                #region 插入排序
                {
                    // 输入有序数组
                    string input = Console.ReadLine();
                    string[] strArray = input.Split(" ");
                    int[] intArray = new int[strArray.Length];
                    for (global::System.Int32 i = 0; i < intArray.Length; i++)
                        intArray[i] = Convert.ToInt32(strArray[i]);

                    Console.WriteLine($"输入一个数：");
                    int n = Convert.ToInt32(Console.ReadLine());
                    int p = 0;
                    for (global::System.Int32 i = 0; i < intArray.Length - 1; i++)
                    {
                        if (n >= intArray[i] && n <= intArray[i + 1])
                        {
                            p = i;
                            break;
                        }
                    }
                    Console.WriteLine($"{n}插入的位置是{p}");
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
