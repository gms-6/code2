using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code22.Model
{
    public class SortMethod
    {
        /// <summary>
        /// 默认从小到大s
        /// </summary>
        /// <param name="nums"></param>
        public void BubbleSort(int[] nums)
        {
            int n= nums.Length;
            for(int i=0;i<n-1;i++)
            {
                for(int j=0;j<n-1-i;j++)
                {
                    if (nums[j] > nums[j+1])
                    {
                        swap(nums,j,j+1);
                    }
                }
            }
        }
        

        private void swap(int[] nums,int a,int b)
        {
            int temp = nums[a];
            nums[a] = nums[b];
            nums[b] = temp;
        }
    }
}
