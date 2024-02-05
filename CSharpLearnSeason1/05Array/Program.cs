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

                    // foreach遍历
                    foreach (var item in nums)
                    {
                        Console.Write("{0}, ", item);
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
