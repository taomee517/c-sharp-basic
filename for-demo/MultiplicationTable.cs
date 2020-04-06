using System;

namespace for_demo
{
    public class MultiplicationTable
    {
        public void PrintTable()
        {
            for (int i = 1; i < 10; i++) {
                for (int j = 1; j < 10; j++)
                {
                    if (i>=j)
                    {
                        Console.Write("{0}*{1}={2} \t", i, j, i*j);
                    }
                    else
                    {
                        continue;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}