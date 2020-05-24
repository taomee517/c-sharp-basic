using System;

namespace event_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //事件类实例化
            var myEvt = new MyEvent();
            
            //事件初始化，事件等于多个委托相加
            myEvt.BuyEvent += new MyEvent.BuyDelegate(MyEvent.BuyFood);
            myEvt.BuyEvent += new MyEvent.BuyDelegate(MyEvent.BuyCake);
            
            myEvt.EventTrigger();
        }
    }
}