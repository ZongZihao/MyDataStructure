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

        /*
         * 归并排序
         */ 
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

        /*
         * 快速排序
         */
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


        public static void BucketSort(int[] list)
        {

        }

        /*
         * 计数排序
         * 时间复杂度O(n)
         * 非原地排序
         */
        public static void CountingSort(int[] list)
        {
            if (list.Length <= 1) return;
            //查找数据范围
            int max = list[0];
            for(int i = 0; i < list.Length; i++)
            {
                if (list[i] > max)
                    max = list[i];
            }

            //创建大小为max + 1的数组
            int[] c = new int[max + 1];

            //计算每个元素的个数放入数组
            for(int i = 0; i < list.Length; i++)
            {
                c[list[i]]++;
            }

            //将c数据进行累加
            for(int i = 1; i < c.Length; i++)
            {
                c[i] = c[i - 1] + c[i];
            }

            //临时数组储存排序后的结果
            int[] tmp = new int[list.Length];

            //计算排序  存入新数组
            for(int i = 0; i < list.Length; i++)
            {
                //计算数据应该在的索引位置
                int index = c[list[i]] - 1;
                //插入数据
                tmp[index] = list[i];
                //计数数组－1;
                c[list[i]]--;
            }

            //赋值到原数组
            for(int i = 0; i < list.Length; i++)
            {
                list[i] = tmp[i];
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

                //string t5 = TimeHelper.Caculate(Sorts.QuickSort, list5);

                string t6 = TimeHelper.Caculate(Sorts.CountingSort, list6);

                //string t6 = TimeHelper.Caculate(Sorts.FindElement, list6, 58, out int res);



                //Console.WriteLine("冒泡排序时间测试, 数据长度{0}:  " + t1 + "s", len);
                //Console.WriteLine("插入排序时间测试, 数据长度{0}:  " + t2 + "s", len);
                //Console.WriteLine("选择排序时间测试, 数据长度{0}:  " + t3 + "s", len);
                //Console.WriteLine("归并排序时间测试, 数据长度{0}:  " + t4 + "s", len);
                //Console.WriteLine("快速排序时间测试, 数据长度{0}:  " + t5 + "s", len);
                Console.WriteLine("计数排序时间测试, 数据长度{0}:  " + t6 + "s", len);
                //Console.WriteLine("查找第K大元素时间测试, 数据长度{0}:  " + t6 + "s   元素值为: " + res, len);

                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------");

            }
        }
    }
}
