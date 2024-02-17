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

                Console.WriteLine($"\n---------------");

                #region 插入排序
                //{
                //    // 输入有序数组
                //    string input = Console.ReadLine();
                //    string[] strArray = input.Split(" ");
                //    int[] intArray = new int[strArray.Length];
                //    for (global::System.Int32 i = 0; i < intArray.Length; i++)
                //        intArray[i] = Convert.ToInt32(strArray[i]);

                //    Console.WriteLine($"输入一个数：");
                //    int n = Convert.ToInt32(Console.ReadLine());
                //    int p = 0;
                //    bool exist = false;
                //    for (global::System.Int32 i = 0; i < intArray.Length - 1; i++)
                //    {
                //        if (intArray[0] > n)
                //        {
                //            p = -1;
                //            exist = true;
                //            break;
                //        }
                //        if (n >= intArray[i] && n <= intArray[i + 1])
                //        {
                //            p = i;
                //            exist = true;
                //            break;
                //        }
                //    }

                //    if (exist == false)
                //        p = intArray.Length;

                //    int[] copyArray = new int[intArray.Length + 1];
                //    for (global::System.Int32 i = 0; i < p + 1; i++)
                //        copyArray[i] = intArray[i];

                //    copyArray[p + 1] = n;

                //    for (global::System.Int32 i = p + 1; i < intArray.Length; i++)
                //        copyArray[i + 1] = intArray[i];
                //    Console.WriteLine($"{n}插入的位置是{p}");

                //    foreach (var item in copyArray)
                //        Console.Write($"{item} ");
                //}
                #endregion

                Console.WriteLine($"\n---------------");

                #region 排序(Array.Sort)
                {
                    int[] intArray = new int[] { 9, 11, 4, 10, 8, 1 };
                    // 系统方法排序
                    Array.Sort(intArray);
                    foreach (var item in intArray)
                        Console.Write(item + " ");
                }
                #endregion

                Console.WriteLine($"\n---------------");

                #region 冒泡排序
                {
                    int[] intArray = new int[] { 9, 11, 4, 8, 22, 10 };
                    for (int i = 0; i < intArray.Length - 1; i++)
                    {
                        // 是否发生交换
                        bool isChange = false;
                        for (global::System.Int32 j = 0; j < intArray.Length - i - 1; j++)
                        {
                            if (intArray[j] > intArray[j + 1])
                            {
                                int temp = intArray[j];
                                intArray[j] = intArray[j + 1];
                                intArray[j + 1] = temp;

                                isChange = true;
                            }
                        }

                        if (!isChange)
                            break;
                    }

                    foreach (var item in intArray)
                        Console.Write($"{item} ");
                }
                #endregion

                Console.WriteLine($"\n---------------");

                #region 不是回文串
                {
                    string inputString = Console.ReadLine();
                    bool isHui = true;
                    for (global::System.Int32 i = 0; i < inputString.Length / 2; i++)
                    {
                        if (inputString[i] != inputString[inputString.Length - 1 - i])
                        {
                            isHui = false; 
                            break;
                        }
                    }
                    Console.WriteLine(isHui);
                }
                #endregion

                Console.WriteLine($"\n---------------");

                #region 最多多少天气温升高
                {
                    string input = Console.ReadLine();
                    string[] strArray = input.Split(" ");
                    int[] intArray = new int[strArray.Length];
                    for (global::System.Int32 i = 0; i < intArray.Length; i++)
                        intArray[i] = Convert.ToInt32(strArray[i]);

                    int maxCount = 1;
                    int count = 1;
                    for (global::System.Int32 i = 0; i < intArray.Length - 1; i++)
                    {
                        if (intArray[i + 1] > intArray[i])
                        {
                            count++;
                        }
                        else
                        {
                            if (count > maxCount)
                                maxCount = count;
                            count = 1;
                        }
                    }
                    Console.WriteLine($"气温升高累计：{maxCount}天");
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
