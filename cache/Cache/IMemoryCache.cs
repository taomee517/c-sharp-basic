﻿using System;
using System.Collections.Generic;

namespace cache.Cache
{
    public interface IMemoryCache
    {
        T Get<T>(string key);

        bool Set<T>(string key, T value, int expire = -1);

        bool Set<T>(string key, T value, TimeSpan expire);

        bool ContainsKey(string key);

        int Remove(params string[] keys);

        T Replace<T>(string key, T value);

        /// <summary>累加，原子操作</summary>
        /// <param name="key">键</param>
        /// <param name="value">变化量</param>
        /// <returns></returns>
        long Increment(string key, long value);

        /// <summary>累加，原子操作</summary>
        /// <param name="key">键</param>
        /// <param name="value">变化量</param>
        /// <returns></returns>
        double Increment(string key, double value);

        /// <summary>递减，原子操作</summary>
        /// <param name="key">键</param>
        /// <param name="value">变化量</param>
        /// <returns></returns>
        long Decrement(string key, long value);

        /// <summary>递减，原子操作</summary>
        /// <param name="key">键</param>
        /// <param name="value">变化量</param>
        /// <returns></returns>
        double Decrement(string key, double value);

        void SetAll<T>(IDictionary<string, T> values, int expire = -1);

        IDictionary<string, T> GetAll<T>(IEnumerable<string> keys);

        string[] Search(string pattern);
    }
}
