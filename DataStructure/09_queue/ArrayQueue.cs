using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    //顺序队列
    class ArrayQueue<T>
    {
        //数组items， 数组大小n
        private T[] items;
        private int n;
        //队头和队尾下标
        int head = 0;
        int tail = 0;

        //初始化申请一个大小为capacity的数组
        public ArrayQueue(int capacity)
        {
            items = new T[capacity];
            n = capacity;
        }

        //入队
        public bool Enqueue(T item)
        {
            //若队列已满
            if (tail == n)
            {
                if (head == 0) return false;
                //数据搬移
                for(int i = head; i < tail; i++)
                {
                    items[i - head] = items[i];
                }
                tail -= head;
                head = 0;
            }

            items[tail] = item;
            tail++;
            return true;
        }

        //出队
        public T dequeue()
        {
            //如果队列为空
            if (head == tail) return default(T);
            T res = items[head];
            head++;
            return res;
        }
    }
}
