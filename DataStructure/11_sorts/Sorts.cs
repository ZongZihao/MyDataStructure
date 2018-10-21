using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class Sorts
    {

        /*
         * 冒泡排序
         * 时间复杂度O(n²)
         * 空间复杂度O(1)
         */
        public static void BubbleSort(int[] list)
        {
            int len = list.Length;
            if (len <= 1) return;
            for(int i = 0; i < len; i++)
            {
                //是否有数据交换
                bool flag = false;
                for(int j = 0; j < len - i - 1; j++)
                {
                    if(list[j] > list[j + 1])
                    {
                        //进行数据交换
                        int tmp = list[j + 1];
                        list[j + 1] = list[j];
                        list[j] = tmp;
                        flag = true;
                    }
                }
                if (!flag) return;
            }
        }

        /*
         * 插入排序
         * 时间复杂度O(n²)
         * 空间复杂度O(1)
         */
        public static void InsertSort(int[] list)
        {
            int len = list.Length;
            if (len <= 1) return;
            for(int i = 1; i < len; i++)
            {
                int value = list[i];
                int j = i - 1;
                for(; j >= 0; j--)
                {
                    if(value < list[j])
                    {
                        //数据搬移
                        list[j + 1] = list[j];
                    }
                    else
                    {
                        break;
                    }
                }
                //插入数据
                list[j + 1] = value;
            }
        }

        /*
         * 选择排序
         * 时间复杂度O(n²)
         * 空间复杂度O(1)
         */
        public static void SelectionSort(int[] list)
        {
            int len = list.Length;
            if (len <= 1) return;
            
            for(int i = 0; i < len - 1; i++)
            {
                //最小值索引
                int index = i;
                for(int j = i +1; j < len; j++)
                {
                    if(list[j] < list[index])
                    {
                        index = j;
                    }
                }
                //交换位置
                int tmp = list[index];
                list[index] = list[i];
                list[i] = tmp;             
            }
        }

        public static void MergeSort(int[] a)
        {
            Merge(a, 0, a.Length - 1);
        }

        private static void Merge(int[] a, int left, int right)
        {
            //基线条件
            if (left >= right) return;

            int mid = (left + right) / 2;
            Merge(a, left, mid);
            Merge(a, mid + 1, right);

            //进行合并操作
            //定义临时数组
            int[] tmp = new int[a.Length];
            //定义临时指针
            int i = left;
            int j = mid + 1;
            int k = 0;

            //排序到临时变量
            while (i <= mid && j <= right)
            {
                if(a[i] < a[j])
                {
                    tmp[k] = a[i];
                    i++;
                }
                else
                {
                    tmp[k] = a[j];
                    j++;
                }
                k++;
            }
            if(i > mid)
            {
                while(j <= right)
                {
                    tmp[k] = a[j];
                    k++;
                    j++;
                }
            }
            else
            {
                while(i <= mid)
                {
                    tmp[k] = a[i];
                    k++;
                    i++;
                }
            }
            //赋值到原数组
            int index = 0;
            while(left <= right)
            {
                a[left] = tmp[index];
                index++;
                left++;
            }

        }


    }


    public class SortsTime
    {
        public static void Time()
        {
            //数据长度
            Console.Write("请输入数据长度: ");
            int len = int.Parse(Console.ReadLine());
            Console.WriteLine();
            var list1 = new int[len];
            var rand = new Random();
            for (int i = 0; i < list1.Length; i++)
            {
                list1[i] = rand.Next(0, 100000);
            }
            var list2 = (int[])list1.Clone();
            var list3 = (int[])list1.Clone();
            var list4 = (int[])list1.Clone();


            string t1 = TimeHelper.Caculate(Sorts.BubbleSort, list1);

            string t2 = TimeHelper.Caculate(Sorts.InsertSort, list2);

            string t3 = TimeHelper.Caculate(Sorts.SelectionSort, list3);

            string t4 = TimeHelper.Caculate(Sorts.MergeSort, list4);



            Console.WriteLine("冒泡排序时间测试, 数据长度{0}:  " + t1 + "s", len);
            Console.WriteLine("插入排序时间测试, 数据长度{0}:  " + t2 + "s", len);
            Console.WriteLine("选择排序时间测试, 数据长度{0}:  " + t3 + "s", len);
            Console.WriteLine("归并排序时间测试, 数据长度{0}:  " + t4 + "s", len);
        }
    }
}
