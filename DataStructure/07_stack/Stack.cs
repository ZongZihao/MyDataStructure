using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    //基于数组实现的顺序栈
    class ArrayStack
    {
        private string[] Items; //数组
        private int N;  //栈的大小
        private int Count; //栈中元素个数

        //初始化数组,申请一个大小为n的数组空间
        public ArrayStack(int n)
        {
            Items = new string[n];
            N = n;
            Count = 0;
        }

        //入栈操作
        public bool Push(string item)
        {
            //数组空间不足返回失败
            if (N == Count) return false;
            //入栈
            Items[Count] = item;
            Count++;
            return true;
        }

        //出栈操作
        public string Pop()
        {
            //栈为空则返回null
            if (Count == 0) return null;
            //出栈
            string res = Items[Count - 1];
            Count--;
            return res;
        }
    }

    //基于数组实现的顺序栈(增加泛型实现)
    class ArrayStack<T>
    {
        private T[] Items; //数组
        private int N;  //栈的大小
        private int Count; //栈中元素个数

        //初始化数组,申请一个大小为n的数组空间
        public ArrayStack(int n)
        {
            Items = new T[n];
            N = n;
            Count = 0;
        }

        //入栈操作
        public bool Push(T item)
        {
            //数组空间不足返回失败
            if (N == Count) return false;
            //入栈
            Items[Count] = item;
            Count++;
            return true;
        }

        //出栈操作
        public T Pop()
        {
            //栈为空则返回null
            if (Count == 0) return default(T);
            //出栈
            T res = Items[Count - 1];
            Count--;
            return res;
        }
    }
}
