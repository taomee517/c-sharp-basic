using System;

namespace event_demo
{
    public class MyEvent
    {
        //定义委托
        public delegate void BuyDelegate();
        
        //定义事件
        public event BuyDelegate BuyEvent;
        
        //定义委托中将会用到的方法
        public static void BuyFood()
        {
            Console.WriteLine("购买快餐！");
        }

        public static void BuyCake()
        {
            Console.WriteLine("购买蛋糕！");
        }
        
        //创建触发事件的方法
        public void EventTrigger()
        {
            //触发事件，必须和事件是同名方法
            BuyEvent();
        }
    }
}