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
            
            // Console.WriteLine("请输入秒数：");
            // int seconds = Convert.ToInt32(Console.ReadLine());
            // const int minuteUnit = 60;
            // const int hourUnit = 60 * minuteUnit;
            // const int dayUnit = 24 * hourUnit;
            // const int monthUnit = 30 * dayUnit;
            // const int yearUnit = 12 * monthUnit;
            //
            // int year = seconds / yearUnit;
            // int restSeconds = seconds % yearUnit;
            // int month = restSeconds/monthUnit;
            // restSeconds = restSeconds % monthUnit;
            // int day = restSeconds / dayUnit;
            // restSeconds = restSeconds % dayUnit;
            // int hour = restSeconds / hourUnit;
            // restSeconds = restSeconds % hourUnit;
            // int minute = restSeconds / minuteUnit;
            // int second = restSeconds % minuteUnit;
            // Console.WriteLine("{0}秒可换算成{1}年{2}月{3}天{4}小时{5}分{6}秒", seconds, year, month, day, hour, minute, second);
            // Console.WriteLine("验证：totalSeconds = {0}", year*yearUnit+month*monthUnit+day*dayUnit+hour*hourUnit+minute*minuteUnit+second);


            // 练习三：string 转日期类型
            
            // string strTime = "2020-04-05 15:27:00";
            // DateTime dateTime = Convert.ToDateTime(strTime);
            // Console.WriteLine(dateTime);

            
            // 练习四：获取时间戳
            
            // TimeSpan timeSpan = DateTime.Now - new DateTime(1970,1,1,0,0,0);
            // long timestamp = Convert.ToInt64(timeSpan.TotalMilliseconds);
            // Console.WriteLine("当前时间戳： timestamp = {0}", timestamp);
            
            
            //练习五： 计算工作日
            // var start = new DateTime(2020,4,24);
            // var end = new DateTime(2020,5,1);
            // var workingDays = DateTimeUtil.CalculateWorkingDays(start, end);
            // Console.WriteLine("工作日总数为：{0}", workingDays);
            
            
            //练习六： 时间转字符串
            // var now = DateTime.Now;
            // //G	Default date & time (long)	10/12/2002 10:11:29 PM
            // Console.WriteLine("当前完整时间：{0:G}", now);
            // //d	Short date	10/12/2002
            // Console.WriteLine("当前日期：{0:d}", now);
            // //T	Long time	10:11:29 PM
            // Console.WriteLine("当前时间：{0:T}", now);
            // var date = now.ToString("yyyy-MM-dd");
            // Console.WriteLine("当前日期（自定义格式）:{0}", date);
            
            
            //练习七： 了解Timespan
            //将时间间隔ts4初始化为7天18小时23分41秒576毫秒（毫秒以千进制）
            var ts = new TimeSpan(7, 18, 23, 41, 576);
            var dt1 = new DateTime(2018, 1, 10, 20, 44, 0);
            var dt2 = DateTime.Now;
            //重新给ts赋值
            ts = dt2 - dt1;  
            Console.WriteLine("时间间隔为：{0}", ts);
            Console.WriteLine("时间间隔的天数部分：{0}", ts.Days);
            Console.WriteLine("时间间隔的小时部分：{0}", ts.Hours);
            Console.WriteLine("时间间隔的分钟部分：{0}", ts.Minutes);
            Console.WriteLine("时间间隔的秒部分：{0}", ts.Seconds);
            Console.WriteLine("时间间隔的毫秒部分：{0}", ts.Milliseconds);
            //输出多少个一百纳秒：30天*24小时*60分*60秒*1000毫秒+03小时*60分*60秒*1000毫秒+09分*60秒*1000毫秒+48秒*1000毫秒+599毫秒=2603388599毫秒，
            //因为刻度是一百纳秒（一千万分之一秒），毫秒为一千分之一秒，所以一毫秒等于1万乘以一百纳秒，所以最后等于2603388599毫秒*10000+5781（个一百纳秒）=26033885995781。
            Console.WriteLine("时间间隔的等效刻度数（计时单位：一百纳秒）：{0}", ts.Ticks); 
            Console.WriteLine("时间间隔的等效天数：{0}", ts.TotalDays);
            Console.WriteLine("时间间隔的等效小时数：{0}", ts.TotalHours);
            Console.WriteLine("时间间隔的等效分钟数：{0}", ts.TotalMinutes);
            Console.WriteLine("时间间隔的等效秒数：{0}", ts.TotalSeconds);
            Console.WriteLine("时间间隔的等效毫秒数：{0}", ts.TotalMilliseconds);


        }
    }
}