using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    public class CommonService
    {
        /// <summary>
        /// 获取无序序列
        /// </summary>
        /// <returns></returns>
        public static int[] GetNoArr()
        {
            int[] arr = { 11, 7, 5, 12, 8, 4, 6, 2, 10, 9, 1, 3 };
            return arr;
        }

        /// <summary>
        /// 获取有序序列
        /// </summary>
        /// <returns></returns>
        public static int[] GetOrderArr()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            return arr;
        }
    }
}
