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
                //此步骤为是否为稳定排序的关键
                if(a[i] <= a[j])
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

        public static void QuickSort(int[] list)
        {
            QuickSortInternal(list, 0, list.Length - 1);
        }

        private static void QuickSortInternal(int[] list, int left, int right)
        {
            //基线条件
            if (left >= right) return;

            //获取pivod分区点
            int pivod = Partition(list, left, right);

            QuickSortInternal(list, left, pivod - 1);
            QuickSortInternal(list, pivod + 1, right);
        }

        private static int Partition(int[] list, int left, int right)
        {
            //未处理区间指针
            int i = left;
            int j = left;
            //定义临时变量
            int tmp;

            //进行分区数据交换
            while(j < right)
            {
                if(list[j] < list[right])
                {
                    tmp = list[j];
                    list[j] = list[i];
                    list[i] = tmp;
                    i++;
                }
                j++;
            }
            //交换已处理区间右侧 和 pivod的位置
            tmp = list[right];
            list[right] = list[i];
            list[i] = tmp;

            //返回pivod
            return i;
        }


        //在O(N)内查找第K大元素
        public static int FindElement(int[] list, int k)
        {
            return FindElementInternal(list, 0, list.Length - 1, k);
        }

        private static int FindElementInternal(int[] list, int left, int right, int k)
        {

            //获取pivod分区点
            int pivod = Partition(list, left, right);
            if (pivod == k - 1) return list[pivod];

            if (pivod > k - 1)
            {
                return FindElementInternal(list, left, pivod - 1, k);
            }
            else
            {
                return FindElementInternal(list, pivod + 1, right, k);
            }

        }
    }

    



    public class SortsTime
    {
        public static void Time()
        {
            while (true)
            {
                //数据长度
                Console.Write("请输入数据长度: ");
                int len = int.Parse(Console.ReadLine());
                Console.WriteLine();
                var list1 = new int[len];
                var rand = new Random();
                for (int i = 0; i < list1.Length; i++)
                {
                    list1[i] = rand.Next(-100000, 100000);
                }
                var list2 = (int[])list1.Clone();
                var list3 = (int[])list1.Clone();
                var list4 = (int[])list1.Clone();
                var list5 = (int[])list1.Clone();
                var list6 = (int[])list1.Clone();


                //string t1 = TimeHelper.Caculate(Sorts.BubbleSort, list1);

                //string t2 = TimeHelper.Caculate(Sorts.InsertSort, list2);

                //string t3 = TimeHelper.Caculate(Sorts.SelectionSort, list3);

                //string t4 = TimeHelper.Caculate(Sorts.MergeSort, list4);

                string t5 = TimeHelper.Caculate(Sorts.QuickSort, list5);

                string t6 = TimeHelper.Caculate(Sorts.FindElement, list6, 58, out int res);



                //Console.WriteLine("冒泡排序时间测试, 数据长度{0}:  " + t1 + "s", len);
                //Console.WriteLine("插入排序时间测试, 数据长度{0}:  " + t2 + "s", len);
                //Console.WriteLine("选择排序时间测试, 数据长度{0}:  " + t3 + "s", len);
                //Console.WriteLine("归并排序时间测试, 数据长度{0}:  " + t4 + "s", len);
                Console.WriteLine("快速排序时间测试, 数据长度{0}:  " + t5 + "s", len);
                Console.WriteLine("查找第K大元素时间测试, 数据长度{0}:  " + t6 + "s   元素值为: " + res, len);

                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------");

            }
        }
    }
}
