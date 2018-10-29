using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class BinarySearch
    {
        //查找第一个值等于给定值的元素
        public static int BsearchFirst(int[] list, int value)
        {
            int len = list.Length;
            int low = 0;
            int high = len - 1;
            while(low <= high)
            {
                int mid = low + ((high - low) >> 1);
                if(list[mid] > value)
                {
                    high = mid - 1;
                }else if(list[mid] < value)
                {
                    low = mid + 1;
                }
                else
                {
                    if (mid == 0 || list[mid - 1] != value)
                        return mid;
                    else
                    {
                        high = mid - 1;
                    }
                }
            }
            return -1;
        }

    }
}
