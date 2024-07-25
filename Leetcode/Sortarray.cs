public class Solution {

     public  int[] SortArray(int[] nums)
 {
     MergeSort(nums, 0, nums.Length - 1);
     return nums;
 }

 private  void MergeSort(int[] arr, int start, int end)
 {
     if (start < end)
     {
         int mid = (start + end) / 2;
         MergeSort(arr, start, mid);
         MergeSort(arr, mid + 1, end);
         Merge(arr, start, mid, end);
     }
 }

 private  void Merge(int[] arr, int start, int mid, int end)
 {
     int n1 = mid - start + 1;
     int n2 = end - mid;
     int[] leftArray = new int[n1 + 1]; // Adding 1 extra for infinity
     int[] rightArray = new int[n2 + 1]; // Adding 1 extra for infinity

     for (int i = 0; i < n1; i++)
         leftArray[i] = arr[start + i];
     leftArray[n1] = int.MaxValue; // Infinity

     for (int j = 0; j < n2; j++)
         rightArray[j] = arr[mid + 1 + j];
     rightArray[n2] = int.MaxValue; // Infinity

     int leftIndex = 0, rightIndex = 0;

     for (int i = start; i <= end; i++)
     {
         if (leftArray[leftIndex] <= rightArray[rightIndex])
         {
             arr[i] = leftArray[leftIndex++];
         }
         else
         {
             arr[i] = rightArray[rightIndex++];
         }
     }
 }

}
