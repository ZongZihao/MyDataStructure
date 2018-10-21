using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DataStructure
{
    /// <summary>
    /// 方法时间计算类
    /// </summary>
    class TimeHelper
    {

        private static Stopwatch sw = new Stopwatch();

        /// <summary>
        /// 无参数,委托无返回值
        /// </summary>
        /// <param name="function"></param>
        /// <returns></returns>
        public static string Caculate(Action function)
        {
            sw.Start();
            function();
            sw.Stop();
            string t = sw.Elapsed.ToString();
            sw.Reset();
            return t;
        }

        /// <summary>
        /// 1个参数,委托无返回
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="function"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static string Caculate<T>(Action<T> function, T param)
        {
            sw.Start();
            function(param);
            sw.Stop();
            string t = sw.Elapsed.ToString();
            sw.Reset();
            return t; 
        }

        /// <summary>
        /// 2个参数,委托无返回
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="function"></param>
        /// <param name="param1"></param>
        /// <param name="param2"></param>
        /// <returns></returns>
        public static string Caculate<T1, T2>(Action<T1, T2> function, T1 param1, T2 param2)
        {
            sw.Start();
            function(param1, param2);
            sw.Stop();
            string t = sw.Elapsed.ToString();
            sw.Reset();
            return t;
        }

        /// <summary>
        /// 无参数,委托有返回
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="function"></param>
        /// <param name="res"></param>
        /// <returns></returns>
        public static string Caculate<T>(Func<T> function, out T res)
        {
            sw.Start();
            res = function();
            sw.Stop();
            string t = sw.Elapsed.ToString();
            sw.Reset();
            return t;
        }

        /// <summary>
        /// 1个参数,委托有返回
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="function"></param>
        /// <param name="param"></param>
        /// <param name="res"></param>
        /// <returns></returns>
        public static string Caculate<T1, T2>(Func<T1, T2> function, T1 param, out T2 res)
        {
            sw.Start();
            res = function(param);
            sw.Stop();
            string t = sw.Elapsed.ToString();
            sw.Reset();
            return t;
        }

        /// <summary>
        /// 2个参数,委托有返回
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <param name="function"></param>
        /// <param name="param1"></param>
        /// <param name="param2"></param>
        /// <param name="res"></param>
        /// <returns></returns>
        public static string Caculate<T1, T2, T3>(Func<T1, T2, T3> function, T1 param1, T2 param2, out T3 res)
        {
            sw.Start();
            res = function(param1, param2);
            sw.Stop();
            string t = sw.Elapsed.ToString();
            sw.Reset();
            return t;
        }

    }
}
