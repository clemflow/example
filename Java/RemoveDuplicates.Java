/*
 Given a sorted array, remove the duplicates in place such that each element appear only once and return the new length.
 Do not allocate extra space for another array, you must do this in place with constant memory.
 For example,
 Given input array A = [1,1,2],
 Your function should return length = 2, and A is now [1,2].
 Solution: Update 7/16/2013: Let j start from 0 for better understanding.
 */
public class Solution {
// <$ tag="duplicates,array,java,test" description="Given a sorted array, remove the duplicates in place such that each element appear only once and return the new length." $$
    public int removeDuplicates(int[] A) {
        int N = A.length;
        int idx = 0;
        for (int i = 0; i < N; ++i) {
            if (i == 0 || A[i] != A[i - 1]) {
                A[idx++] = A[i];
            }
        }
        return idx;
    }
// $>

}