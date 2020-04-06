using System;
using for_demo;

namespace method_demo
{
    public class ArrayUtil
    {
        /// <summary>
        /// 算出数组的关键属性
        /// </summary>
        /// <param name="array">任意数组</param>
        /// <returns>数组属性</returns>
        public ArrayInfo CalArrayInfo(int[] array)
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
            Save2Decimal(ref avg);
            return new ArrayInfo
            {
                _max = max,
                _min = min,
                _sum = sum,
                _avg = avg
            };
        }


        /// <summary>
        /// 计算数组中的最大值，最小值，总和，平均值，并通过out参数返回
        /// </summary>
        /// <param name="array">任意数组</param>
        /// <param name="max">最大值</param>
        /// <param name="min">最小值</param>
        /// <param name="sum">总和</param>
        /// <param name="avg">平均值</param>
        public void GetMinMax(int[] array, out int max, out int min, out int sum, out double avg)
        {
            max = int.MinValue;
            min = int.MaxValue;
            sum = 0;
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

            avg = (double) sum / array.Length;
        }

        /// <summary>
        /// 保留两位小数
        /// </summary>
        /// <param name="value">源double类型的参数</param>
        public static void Save2Decimal(ref double value)
        {
            string temp = value.ToString("0.00");
            value = Double.Parse(temp);
        }
    }
}