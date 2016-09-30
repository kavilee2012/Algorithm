using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    public class Dichotomy
    {
        /// <summary>
        /// 二分法查找
        /// </summary>
        /// <param name="arr">有序序列</param>
        /// <param name="aim">查找目标</param>
        public static void StartDichotomy(int[] arr, int aim)
        {
            int low = 0; //最小下标
            int high = arr.Length - 1;  //最大下标
            int mid = 0;  //中间取值下标
            int count = 0; //计算次数

            bool result = false; //是否查找到目标数字

            while (low <= high)
            {
                count++;

                mid = (high + low) / 2; //每次取中间值下标
                if (arr[mid] < aim)
                {
                    low = mid + 1;
                }
                else if (arr[mid] > aim)
                {
                    high = mid - 1;
                }
                else
                {
                    result = true;
                    break;
                }
            }

            Console.WriteLine("查找结果：" + (result ? "成功" : "失败"));
            Console.WriteLine("计算次数：" + count);
        }
    }
}
