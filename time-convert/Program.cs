using System;

namespace time_convert
{
    class Program
    {
        static void Main(string[] args)
        {
            // 练习一：将控制台输入的天数转化为多少周，多少天
            
            // Console.WriteLine("请输入天数：");
            // int days = Convert.ToInt32(Console.ReadLine());
            // int weeks = days / 7;
            // int restDays = days % 7;
            // if (restDays==0)
            // {
            //     Console.WriteLine("{0}天可换算成{1}周", days, weeks);
            // }
            // else
            // {
            //     Console.WriteLine("{0}天可换算成{1}周{2}天", days, weeks, restDays);
            // }
            

            // 练习二：将控制台输入的秒数转化成多少年，多少月，多少天，多少小时，多少分，多少秒
            
            Console.WriteLine("请输入秒数：");
            int seconds = Convert.ToInt32(Console.ReadLine());
            const int minuteUnit = 60;
            const int hourUnit = 60 * minuteUnit;
            const int dayUnit = 24 * hourUnit;
            const int monthUnit = 30 * dayUnit;
            const int yearUnit = 12 * monthUnit;
            
            int year = seconds / yearUnit;
            int restSeconds = seconds % yearUnit;
            int month = restSeconds/monthUnit;
            restSeconds = restSeconds % monthUnit;
            int day = restSeconds / dayUnit;
            restSeconds = restSeconds % dayUnit;
            int hour = restSeconds / hourUnit;
            restSeconds = restSeconds % hourUnit;
            int minute = restSeconds / minuteUnit;
            int second = restSeconds % minuteUnit;
            Console.WriteLine("{0}秒可换算成{1}年{2}月{3}天{4}小时{5}分{6}秒", seconds, year, month, day, hour, minute, second);
            Console.WriteLine("验证：totalSeconds = {0}", year*yearUnit+month*monthUnit+day*dayUnit+hour*hourUnit+minute*minuteUnit+second);


            // 练习三：string 转日期类型
            
            // string strTime = "2020-04-05 15:27:00";
            // DateTime dateTime = Convert.ToDateTime(strTime);
            // Console.WriteLine(dateTime);

            
            // 练习四：获取时间戳
            
            TimeSpan timeSpan = DateTime.Now - new DateTime(1970,1,1,0,0,0);
            long timestamp = Convert.ToInt64(timeSpan.TotalMilliseconds);
            Console.WriteLine("当前时间戳： timestamp = {0}", timestamp);
        }
    }
}