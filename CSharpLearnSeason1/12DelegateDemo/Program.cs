namespace _12DelegateDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Console.WriteLine("Season1: 12DelegateDemo\n");

                #region 委托使用
                {
                    Play(ShowUI);
                }
                #endregion
            }
            catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }



        delegate void DeathDelagate();

        static void Play(DeathDelagate deathDelagate)
        {
            Console.WriteLine("做任务");
            Console.WriteLine($"玩家正在战斗");
            Console.WriteLine("玩家死亡");

            if (deathDelagate != null)
                deathDelagate();
        }

        static void ShowUI()
        {
            Console.WriteLine("显示玩家死亡后的UI");
            Console.WriteLine("返回首页的UI");
        }
    }
}
