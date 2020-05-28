using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using delegate_demo.delegates;
using delegate_demo.methods;

namespace delegate_demo
{
    class Program
    {
        delegate void ShowCalculate(int x);
        
        delegate string CompleteTask(int x);
        
        static void Main(string[] args)
        {
            // 完整版写法
            // const int param = 3;
            // var t = new TransformDelegate.Transform(TransformMethods.Square);
            // var result = t.Invoke(param);
            // Console.WriteLine("委托执行结果是：{0}", result);
            
            
            // 缩略版写法
            // const int param = 3;
            // TransformDelegate.Transform t = TransformMethods.Square;
            // var result = t(param);
            // Console.WriteLine("委托执行结果是：{0}", result);
            
            
            // 多播委托->一组参数经多方处理，结果没有传递
            const int param = 3;
            var t = new TransformDelegate.Transform(TransformMethods.Square);
            t += TransformMethods.Double;
            var result = t.Invoke(param);
            Console.WriteLine("委托执行结果是：{0}", result);
            
            var show = new ShowCalculate(TransformMethods.ShowSquare);
            show += TransformMethods.ShowDouble;
            show(param);


            Console.WriteLine(GetReply(6).Result);
        }


        public static async Task<string> GetReply(int val)
        {
            string reply = null;
            Func<int, string> completeFunc = i =>
            {
                reply = Convert.ToString(i);
                return reply;
            };
            var delegateMap = new Dictionary<int,Delegate>(); 
            delegateMap.Add(val,completeFunc);
            await Task.Factory.StartNew(() =>
            {
                Thread.Sleep(3000);
                var dt = delegateMap[val];
                return dt.DynamicInvoke(val + 10);
            });
            return reply;
        }
    }
}