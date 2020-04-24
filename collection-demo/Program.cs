using System;
using System.Collections;
using System.Collections.Specialized;

namespace collection_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //队列
            // var queue = new Queue();
            // queue.Enqueue("小张");
            // queue.Enqueue("小李");
            // queue.Enqueue("小刘");
            // while (queue.Count!=0)
            // {
            //     Console.WriteLine(queue.Dequeue() + "已购票！");
            // }
            // Console.WriteLine("所有人已购票！");
            
            
            //栈
            // var stack = new Stack();
            // //向栈中存放元素
            // for (int i = 0; i < 5; i++)
            // {
            //     var name = (i + 1) + " 号盘子";
            //     stack.Push(name);
            //     Console.WriteLine("{0}入栈！", name);
            // }
            // //判断栈中是否有元素
            // while(stack.Count != 0)
            // {
            //     //取出栈中的元素
            //     Console.WriteLine("取出{0}", stack.Pop());
            // }
            
            
            //HashTable
            //取代 HashTable ht = new HashTable()的写法 
            var ht = CollectionsUtil.CreateCaseInsensitiveHashtable();
            ht.Add(1, "计算机基础");
            ht.Add(2, "C#高级编程");
            ht.Add(3, "数据库应用");
            Console.WriteLine("请输入图书编号");
            var id = int.Parse(Console.ReadLine());
            var flag = ht.ContainsKey(id);
            if (flag)
            {
                Console.WriteLine("您查找的图书名称为：{0}", ht[id].ToString());
            }
            else
            {
                Console.WriteLine("您查找的图书编号不存在！");
                Console.WriteLine("所有的图书信息如下：");
                foreach(DictionaryEntry d in ht)
                {
                    var key = (int)d.Key;
                    var value = d.Value.ToString();
                    Console.WriteLine("图书编号：{0}，图书名称：{1}", key, value);
                }
            }
        }
    }
}