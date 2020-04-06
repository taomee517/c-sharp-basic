using System;
using System.Collections.Generic;

namespace for_demo
{
    public class NarcissisticNumber
    {
        /// <summary>
        /// 找出start-end之间的水仙花数
        /// 什么是水仙花数？
        /// 如153 1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153
        /// </summary>
        public void FindAndPrintNarcissisticNumbers(int start, int end)
        {
            List<int> narcissisticNumbers = new List<int>();
            for (int i=start;i<=end;i++)
            {
                int hundreds = i / 100;
                int temp = i % 100;
                int tens = temp / 10;
                int singles = temp % 10;
                int sum = hundreds * hundreds * hundreds + tens * tens * tens + singles * singles * singles;
                if (i == sum)
                {
                    Console.WriteLine("水仙花：{0} = {1}^3 + {2}^3 +{3}^3", i, hundreds, tens, singles);
                    narcissisticNumbers.Add(i);
                }
            }

            int size = narcissisticNumbers.Count;
            Console.Write("从{0}到{1}总共找到{2}个水仙花数，分别是：", start, end, size);
            for (int i = 0; i < size; i++)
            {
                if (i==(size-1))
                {
                    Console.Write(narcissisticNumbers[i]);
                }
                else
                {
                    Console.Write(narcissisticNumbers[i] + ",");
                }
            }
            Console.WriteLine();
        }
    }
}