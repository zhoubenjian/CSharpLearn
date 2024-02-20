namespace _08Overload
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Console.WriteLine("Season1: 08Overload\n");

                int[] intArray = { 1, 2, 3, 4 };
                Console.WriteLine(MaxValue(intArray));

                double[] doubleArray = { 2, 3, 5, 7 };
                Console.WriteLine(MaxValue(doubleArray));
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }


        
        /// <summary>
        /// 方法重载
        /// </summary>
        /// <param name="intArray"></param>
        /// <returns></returns>

        static int MaxValue(int[] intArray)
        {
            int maxValue = intArray[0];
            for (int i = 1; i < intArray.Length; i++)
            {
                if (intArray[i] > maxValue)
                    maxValue = intArray[i];
            }
            return maxValue;
        }

        /// <summary>
        /// 方法重载
        /// </summary>
        /// <param name="doubleArray"></param>
        /// <returns></returns>
        static double MaxValue(double[] doubleArray)
        {
            double maxValue = doubleArray[0];
            for (int i = 1; i < doubleArray.Length; i++)
            {
                if (doubleArray[i] > maxValue)
                    maxValue = doubleArray[i];
            }
            return maxValue;
        }
    }
}
