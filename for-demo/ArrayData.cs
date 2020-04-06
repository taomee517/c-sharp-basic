using System;

namespace for_demo
{
    public class ArrayData
    {
        public void FindMinMax(int[] array)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            int sum = 0;
            foreach (var i in array)
            {
                if (i>max)
                {
                    max = i;
                }

                if (i<min)
                {
                    min = i;
                }

                sum += i;
            }

            double avg = (double) sum / array.Length;
            Console.WriteLine("数组的最大值是：{0}，最小值是：{1}， 总和是：{2}， 平均值是：{3:0.00}", max, min, sum, avg);
        }
    }
}