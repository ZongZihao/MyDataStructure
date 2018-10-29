using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure._11_sorts
{
    class FindKth
    {

        //在O(N)内查找第K大元素
        //依据快排思想
        public static int FindKthLargest(int[] nums, int k)
        {

            return Find(nums, 0, nums.Length - 1, k);

        }

        public static int Find(int[] nums, int left, int right, int k)
        {

            //分区返回轴心点
            int pivot = Partition2(nums, left, right);

            if (pivot + 1 == k)
            {
                return nums[pivot];
            }
            else if (pivot + 1 < k)
            {
                return Find(nums, pivot + 1, right, k);
            }
            else
            {
                return Find(nums, left, pivot - 1, k);
            }
        }

        public static int Partition2(int[] nums, int left, int right)
        {

            //选取pivot
            int pivot = right;
            //快慢两指针,区分已处理区间
            int slow = left;
            int fast = left;
            for (; fast <= right; fast++)
            {
                //倒叙排序
                if (nums[fast] >= nums[pivot])
                {
                    //交换
                    int tmp = nums[slow];
                    nums[slow] = nums[fast];
                    nums[fast] = tmp;
                    //已处理区间+1
                    slow++;
                }
            }
            return slow - 1;

        }

        //选择排序法
        public static int FindKthLargest2(int[] nums, int k)
        {

            for (int i = 0; i < k; i++)
            {
                //最大值索引
                int index = i;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] > nums[index])
                    {
                        index = j;
                    }
                }
                //交换位置
                int tmp = nums[index];
                nums[index] = nums[i];
                nums[i] = tmp;
            }
            return nums[k - 1];
        }

        public class FindsTime
        {
            public static void Time()
            {
                while (true)
                {
                    //数据长度
                    Console.Write("请输入数据长度: ");
                    int len = int.Parse(Console.ReadLine());
                    //查找k
                    Console.Write("请输入K: ");
                    int k = int.Parse(Console.ReadLine());

                    Console.WriteLine();
                    var list1 = new int[len];
                    var rand = new Random();
                    for (int i = 0; i < list1.Length; i++)
                    {
                        list1[i] = rand.Next(-100000, 100000);
                    }
                    var list2 = (int[])list1.Clone();

                    string t1 = TimeHelper.Caculate(FindKthLargest, list1, k, out int res1);
                    //string t2 = TimeHelper.Caculate(FindKthLargest2, list2, k, out int res2);

                    Console.WriteLine("快速排序思想: {0}s, 结果为: {1}", t1, res1);
                    //Console.WriteLine("选择排序思想: {0}s, 结果为: {1}", t2, res2);

                    Console.WriteLine();
                    Console.WriteLine("--------------------------------------------------");

                }
            }
        }

    }
}
