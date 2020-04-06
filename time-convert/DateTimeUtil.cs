﻿using System;

namespace time_convert
{
    public class DateTimeUtil
    {
        /// <summary>
        /// 获取当前时间的微秒级时间戳
        /// </summary>
        /// <returns></returns>
        public static long GetMilliSecondTimestamp()
        {
            TimeSpan timeSpan = DateTime.Now - new DateTime(1970,1,1,0,0,0);
            long timestamp = Convert.ToInt64(timeSpan.TotalMilliseconds);
            return timestamp;
        }
        
        public static long GetSecondTimestamp()
        {
            TimeSpan timeSpan = DateTime.Now - new DateTime(1970,1,1,0,0,0);
            long timestamp = Convert.ToInt64(timeSpan.TotalSeconds);
            return timestamp;
        }

        /// <summary>
        /// 判断是否闰年
        /// </summary>
        /// <param name="year">输入的年份</param>
        /// <returns>bool</returns>
        public static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
}