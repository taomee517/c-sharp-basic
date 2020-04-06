using System;
using System.Collections.Generic;

namespace for_demo
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //找出100-999之间的水仙花数
            NarcissisticNumber nn = new NarcissisticNumber();
            nn.FindAndPrintNarcissisticNumbers(100,999);
            
            //打印乘法口诀表
            MultiplicationTable mt = new MultiplicationTable();
            mt.PrintTable();
            
            //找出所有质数
            PrimeNumber pn = new PrimeNumber();
            pn.FindAndPrint(1,99);

            //找出并打印数组中的最大，最小值, 总和，平均值
            int[] array = new[] {23, 134, 64, 15, 9, 98, 46};
            ArrayData ad = new ArrayData();
            ad.FindMinMax(array);
        }
    }
}