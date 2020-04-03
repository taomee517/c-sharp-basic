
using System;

namespace console_demo
{
    public class ArrayShow
    {
        private static readonly int [] IntArray = new int[5]{9,2,4,11,5};

        public void ArrayPrint()
        {
            Array.Sort(IntArray);
            foreach (var data in IntArray)
            {
                Console.WriteLine(data);
            }
        }
    }
}