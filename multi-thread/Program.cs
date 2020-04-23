using System;
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
            

            //case 2: thread pool
            // ThreadPool.QueueUserWorkItem(new WaitCallback(state => {Go();}));
            
            var firstStep = new Task<int>(()=>1*5);
            var secondStep = firstStep.ContinueWith((firstResult) => firstResult.Result * 5);
            firstStep.Start();
            Console.WriteLine("第二步的结果：result = {0}", secondStep.Result);
        }
        
        private static void Record(string name)
        {
            Console.WriteLine("accept name = {0}", name);
        }

        private static void Go()
        {
            Console.WriteLine("开启新线程任务！ thread = {0}", Thread.CurrentThread.ManagedThreadId);
        }
    }
}