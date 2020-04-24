using System;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;
using JsonConverter = System.Text.Json.Serialization.JsonConverter;

namespace class_demo
{
    class Program
    {
       public static void Main(string[] args)
       {
           //类的初始化及方法调用
           // var box = new Box
           // {
           //     Height = 10.0,
           //     Width = 10.0,
           //     Length = 50.0
           // };
           //  var volume = box.CalVolume();
           //  Console.WriteLine("volume of box is :{0}", volume);
           //  
           //  Shape rect = new Rectangle
           //  {
           //      Length = 20.0,
           //      Width = 4.0
           //  };
           //  Shape triangle = new Triangle(8.0,6.0);
           //  var calculator = new Calculator();
           //  var rectArea = calculator.CallArea(rect);
           //  var triangleArea = calculator.CallArea(triangle);
           //  Console.WriteLine("长方形的面积是：{0}", rectArea);
           //  Console.WriteLine("三角形的面积是：{0}", triangleArea);
           //  var json = JsonConvert.SerializeObject(box, Formatting.None);
           //  Console.WriteLine("shape json: {0}", json);
            
           //对象转json案例
            Account account = new Account();
            account.Name = "taomee";
            account.Phone = "13167818993";
            account.Balance = 653.2;
            string accJson = JsonConvert.SerializeObject(account);
            Console.WriteLine("account json: {0}", accJson);

            
            //类型判断
            var accountType = account.GetType();
            Console.WriteLine("账户的类型：{0}", accountType);
            
            var flag = account!=null && account is Account;
            Console.WriteLine("类型判断结果：{0}",flag);
       }
    }
}