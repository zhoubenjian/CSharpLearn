namespace _07Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Console.WriteLine("Season1: 07Function\n");

                #region 给定区间内的真素数
                {
                    string input = Console.ReadLine();
                    string[] strArray = input.Split(" ");

                    int minNum = Convert.ToInt32(strArray[0]);
                    int maxNum = Convert.ToInt32(strArray[1]);

                    Console.Write($"{minNum}-{maxNum}之间的真素数：");
                    for (global::System.Int32 i = minNum; i <= maxNum; i++)
                    {
                        bool isPrime1 = true;
                        for (global::System.Int32 j = 2; j < i; j++)
                        {
                            if (i % j == 0)
                            {
                                isPrime1 = false;
                                break;
                            }
                        }

                        if (isPrime1)
                        {
                            int reverseNum = 0;
                            int temp = i;
                            // 逆序
                            while ((temp % 10) != 0)
                            {
                                reverseNum = reverseNum * 10 + (temp % 10);
                                temp /= 10;
                            }

                            bool isPrime2 = true;
                            for (global::System.Int32 j = 2; j < reverseNum; j++)
                            {
                                if (reverseNum % j == 0)
                                {
                                    isPrime2 = false;
                                    break;
                                }
                            }

                            if (isPrime2)
                                Console.Write($"{i} ");
                        }
                    }
                }
                #endregion

                Console.WriteLine($"----------------\n");

                #region 参数数组
                {
                    int[] intArray = new int[] { 2, 3, 5, 7, 11, 13, 17, 19 };
                    Console.WriteLine($"{Add1(intArray)}");
                    Console.WriteLine($"{Add1(new int[] { 1, 3, 5, 7, 9 })}");

                    Console.WriteLine($"{Add2(2, 4, 6, 8, 10)}");
                }
                #endregion

                Console.WriteLine($"----------------");

                #region 计算约数
                {
                    int[] result = GetDivisor(10);
                    foreach (var item in result)
                        Console.Write($"{item} ");
                }
                #endregion
            }
            catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }



        static int Add1(int[] array) 
        {
            int sum = 0;
            foreach (var item in array)
                sum += item;
            return sum;
        }

        static int Add2(params int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
                sum += array[i];
            return sum;
        }



        static int[] GetDivisor(int num) 
        {
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                    count++;
            }

            int[] result = new int[count];
            int index = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    result[index] = i;
                    index++;
                }
            }

            return result;
        }
    }
}
