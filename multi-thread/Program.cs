using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace multi_thread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("主线程, thread = {0}",Thread.CurrentThread.ManagedThreadId);
            //case 1: thread create
            // new 一个Thread后要调用Start() 线程才会开始执行
            // new Thread(Go).Start();
            

            //TaskFactory的StartNew()方法创建任务
            // Task.Factory.StartNew(Go);
            // Task.Factory.StartNew(() => Console.WriteLine("执行新线程任务，thread = {0}", Thread.CurrentThread.ManagedThreadId));
            // var msgTask = Task.Factory.StartNew<string>(() => "Hello,World! from " + Thread.CurrentThread.ManagedThreadId);
            // Console.WriteLine("从新线程任务中得到执行结果：result = {0}",msgTask.Result);
            
            
            //调用Start方法手动启动
            // var task = new Task<string>(()=>"Hello,World! from " + Thread.CurrentThread.ManagedThreadId);
            // //异步执行
            // task.Start();
            // Console.WriteLine("从新线程任务中得到执行结果：result = {0}",task.Result);
            // Task.Run(new Action(Go));
            
            
            //调用RunSynchronously方法手动启动
            // var task = new Task<string>(()=>"Hello,World! from " + Thread.CurrentThread.ManagedThreadId);
            // //同步执行
            // task.RunSynchronously();
            // Console.WriteLine("从新线程任务中得到执行结果：result = {0}",task.Result);
            
            
            //责任链模式
            // var firstStep = new Task<int>(()=>1*5);
            // var secondStep = firstStep.ContinueWith((firstTask) => firstTask.Result * 5);
            // firstStep.Start();
            // Console.WriteLine("第二步的结果：result = {0}", secondStep.Result);
            
            
            //waitAny 与 waitAll
            // var tasks = new Task[3];
            // for (var i = 0; i < tasks.Length; i++)
            // {
            //     var index = i;
            //     tasks[i] = Task.Factory.StartNew(() => {Console.WriteLine("执行任务{0}", index);});
            // }
            // Task.WaitAny(tasks);
            // Console.WriteLine("已有任务完成！");
            //
            // Task.WaitAll(tasks);
            // Console.WriteLine("所有任务已完成！");
            
            
            //Exception handle
            // var task = Task.Factory.StartNew(() =>
            //     {
            //         Task.Factory.StartNew(() => { throw new Exception("child exception"); }, TaskCreationOptions.AttachedToParent);
            //     });
            // task.Wait();
            
            
            //task cancel
            // var source = new CancellationTokenSource();
            // var token = source.Token;
            // var task = Task.Factory.StartNew(() =>
            // {
            //     Console.WriteLine("task start");
            //     //开启一个循环任务
            //     while (true)
            //     {
            //         token.ThrowIfCancellationRequested();
            //         Console.WriteLine("I'm still alive. current time is {0}", DateTime.Now);
            //         Thread.Sleep(1000);
            //     }
            // }, token);
            //
            // var cancelTask = Task.Factory.StartNew(() =>
            // {
            //     //4.5秒后中止任务
            //     Thread.Sleep(4500);
            //     source.Cancel();
            // });
            //
            // try
            // {
            //     task.Wait();
            //     Console.WriteLine("task stopped");
            // }
            // catch(Exception e)
            // {
            //     if (e.InnerException is OperationCanceledException)
            //     {
            //         Console.WriteLine("task canceled");
            //     }
            //     else
            //     {
            //         Console.WriteLine("Error");
            //     }
            // }
            
            
            //Action
            Action<string> act = SayHi;
            for (var i = 0; i < 4; i++)
            {
                var tempName = "name_" + i;
                act(tempName);
            }


            //case 2: thread pool
            // ThreadPool.QueueUserWorkItem(new WaitCallback(state => {Go();}));

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(GetSerial("key"));
            }
        }
        
        private static void Record(string name)
        {
            Console.WriteLine("accept name = {0}", name);
        }

        private static void Go()
        {
            Console.WriteLine("开启新线程任务！ thread = {0}", Thread.CurrentThread.ManagedThreadId);
        }

        private static Task<string> SayHello()
        {
            return Task.Factory.StartNew(() => "Hello!");
        }

        private static void SayHi(string name)
        {
            Console.WriteLine("任务线程, thread = {0}",Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Hi,{0}!",name);
        }
        
        private static ConcurrentDictionary<string,int> SerialMap = new ConcurrentDictionary<string, int>();

        public static int GetSerial(string key)
        {
            var serial = 0;
            if (!SerialMap.ContainsKey(key))
            {
                SerialMap[key] = serial;
                return serial;
            }
            var temp = SerialMap[key];
            serial = Interlocked.Increment(ref temp)% 0x100;
            SerialMap[key] = serial;
            return serial;
        }
        
    }
}