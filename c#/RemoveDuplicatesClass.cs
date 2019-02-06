/**********************************************************************************
*
* 
* Given a sorted array, remove the duplicates in place such that each element appear only once and return the new length.
* 
* 
* Do not allocate extra space for another array, you must do this in place with constant memory.
* 
* 
* 
* For example,
* Given input array nums = [1,1,2],
* 
* 
* Your function should return length = 2, with the first two elements of nums being 1 and 2 respectively. 
* It doesn't matter what you leave beyond the new length.
* 
*
**********************************************************************************/

using System;
using System.Collections.Generic;
using Algorithms.Utils;
namespace Algorithms
{
    public class RemoveDuplicatesClass
    {
        // <$ tag="duplicates,array,c#,test" description="Given a sorted array, remove the duplicates in place such that each element appear only once and return the new length."
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length <= 1) return nums.Length;
            var index = 1;
            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[index - 1])
                {
                    nums[index] = nums[i];
                    index++;
                }
            }
            return index;
        }
        // $>
    }
}

