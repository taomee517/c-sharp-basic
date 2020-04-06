using System;

namespace for_demo
{
    public class ArrayData
    {
        /// <summary>
        /// 找出数组中的最大，最小值，总和，平均值
        /// </summary>
        /// <param name="array">要计算的数组</param>
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
        

        /// <summary>
        /// 冒泡排序
        /// </summary>
        /// <param name="array">要排序的数组</param>
        /// <param name="sort">排序类型，ASC-升序，DESC-降序</param>
        /// <returns>排序后的数组</returns>
        public int[] PopSort(int[] array, SortType sort)
        {
            for (int i = 0; i < array.Length; i++)
            {
                
                for (int j = 0; j < array.Length-1-i; j++)
                {
                    int value = array[j];
                    int nextValue = array[j+1];
                    if (SortType.ASC == sort && value>nextValue
                        || SortType.DESC == sort && value<nextValue)
                    {
                        array[j+1] = value;
                        array[j] = nextValue;
                    }
                }
            }
            return array;
        }

        //打印数组的所有元素
        public void ArrayShow(int[] array)
        {
            foreach (var o in array)
            {
                Console.Write(o.ToString() +　"\t");
            }
        }
    }
}