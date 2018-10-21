using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class Sorts
    {
        public static void BubbleSort(int[] a)
        {
            int len = a.Length;
            if (len <= 1) return;
            for(int i = 0; i < len; i++)
            {
                //是否有数据交换
                bool flag = false;
                for(int j = 0; j < len - i - 1; j++)
                {
                    if(a[j] > a[j + 1])
                    {
                        //进行数据交换
                        int tmp = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = tmp;
                        flag = true;
                    }
                }
                if (!flag) return;
            }
        }
        
        public static void InsertSort(int[] a)
        {
            int len = a.Length;
            if (len <= 1) return;
            for(int i = 1; i < len; i++)
            {
                int value = a[i];
                int j = i - 1;
                for(; j >= 0; j--)
                {
                    if(value < a[j])
                    {
                        //数据搬移
                        a[j + 1] = a[j];
                    }
                    else
                    {
                        break;
                    }
                }
                //插入数据
                a[j + 1] = value;
            }
        }

        public static void SelectionSort(int[] a)
        {
            int len = a.Length;
            if (len <= 1) return;
            
            for(int i = 0; i < len - 1; i++)
            {
                //最小值索引
                int index = i;
                for(int j = i +1; j < len; j++)
                {
                    if(a[j] < a[index])
                    {
                        index = j;
                    }
                }
                //交换位置
                int tmp = a[index];
                a[index] = a[i];
                a[i] = tmp;             
            }
        }
    }
}
