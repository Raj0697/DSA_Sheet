package sde_sheet;

import java.util.Arrays;

public class Third_max_number {
	
	public static void main(String[] args) {
		int[] ar = {2,1,2};
		//thirdMax(ar);
		//System.out.println(Arrays.toString(ar));
		System.out.println(thirdMax(ar));
		System.out.println(removeDuplicateElements(ar, ar.length));
		//Arrays.sort(ar);
	}
	
	public static int thirdMax(int[] nums) {
        int temp=0;
        for (int i = 0; i < nums.length; i++) {   
            for (int j = i+1; j < nums.length; j++) {   
               if(nums[i] < nums[j]) {  
                   temp = nums[i];  
                   nums[i] = nums[j];  
                   nums[j] = temp;  
               }   
            }   
        }
        int t = removeDuplicateElements(nums, nums.length);
        for(int i=0; i<t; i++) {
        	System.out.print(nums[i]+ " ");
        }
        System.out.println();
        if(t > 2)
            return nums[2];
        
        return nums[0];
        
    }
    public static int removeDuplicateElements(int arr[], int n){  
        if (n==0 || n==1){  
            return n;  
        }    
        int j = 0;//for next element  
        for (int i=0; i < n-1; i++){  
            if (arr[i] != arr[i+1]){  
                arr[j++] = arr[i];  
            }  
        }  
        arr[j++] = arr[n-1];  
        return j;  
    }  
	
//	public static void thirdMax(int[] nums) {
//        int max=0, s=0;
////        if(nums.length <= 2)
////            //return getmax(nums, 0, nums.length-1);
////            return 2;
//        for(int i=0; i<nums.length; i++) {
//            int last = nums.length - i - 1;
//            int maxindex = getmax(nums, 0, last);
//            swap(nums, maxindex, last);
//        }
//        //return s;
//    }
//    
//    public static void swap(int[] ar, int first, int second){
//        int temp = ar[first];
//        ar[first] = ar[second];
//        ar[second] = temp;
//        //return temp;
//    }
//    
//    public static int getmax(int[] ar, int start, int end) {
//        int max = start;
//        for(int i=start; i<=end; i++){
//            if(ar[i] > ar[max]){
//                max =  i;
//            }
//        }
//        return max;
//    }
}
