using System;

namespace for_demo
{
    public class PrimeNumber
    {
        public void FindAndPrint(int start, int end)
        {
            if (start<=0)
            {
                Console.WriteLine("start 不能小于0");
                return;
            }
            
            for (int i = start; i <= end; i++)
            {
                if (i<=2)
                {
                    Console.WriteLine("找到质数：{0}", i);
                }
                else
                {
                    bool flag = true;
                    for (int j = i - 1; j > 1; j--)
                    {
                        if (i % j == 0)
                        {
                            flag = false;
                            break;
                        }
                    }

                    if (flag)
                    {
                        Console.WriteLine("找到质数：{0}", i);
                    } 
                }
            }
        }
    }
}