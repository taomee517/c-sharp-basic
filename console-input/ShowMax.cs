using System;

namespace console_input
{
    public class ShowMax
    {
        static void Main(string[] args)
        {
            string input = null;
            int max = 0;
            
            while (true)
            {
                Console.WriteLine("请输入一个整数：");
                input = Console.ReadLine();
                try
                {
                    int value = Convert.ToInt32(input);
                    if (value > max)
                    {
                        max = value;
                    }
                }
                catch (Exception e)
                {
                    if (input != "end")
                    {
                        Console.WriteLine("{0}不能转为整数", input);
                        throw;
                    }
                    else
                    {
                        Console.WriteLine("您输入的数字中最大值为：{0}", max);
                        break;
                    }
                }
            }
        }
    }
}