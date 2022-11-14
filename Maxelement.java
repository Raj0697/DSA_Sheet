package sde_sheet;

public class Maxelement {
	
	public static void main(String[] args) {
		//int[] ar = {2,10,7,5,4,1,8,6};
		//int[] ar = {0,-4,19,1,8,-2,-3,5};
		int[] ar = {-1,-53,93,-42,37,94,97,82,46,42,-99,56,-76,-66,-67,-13,10,66,85,-28};
		System.out.println(minimumDeletions(ar));
	}

	public static int minimumDeletions(int[] nums) {
//        int min = nums[0], max = nums[0], minindex=0, maxindex=0, temp=0, n=nums.length;
//        for(int i=1; i<nums.length; i++){ // [0,-4,19,1,8,-2,-3,5]
//            if(nums[i] > max){
//                max = nums[i];
//                maxindex = i;
//            }
//            if(nums[i] < min){
//                min = nums[i];
//                minindex = i;
//            }
//        }
//        
//        int start=0, end=n-1, count1=0, count2=0;
//        //while(start < end){
//        if((minindex <= n/2) && (maxindex <= n/2)){
//            //hello(start, minindex, maxindex);
//            count1 = minindex - start;
//            count2 = maxindex - start;
//        }
//        if((minindex >= n/2) && (maxindex >= n/2)){
//            //hello(end, minindex, maxindex);
//            count1 = end - minindex;
//            count2 = end - maxindex;
//        }
//        if((minindex <= n/2) && (maxindex >= n/2)){
//        	count1 = (minindex - start)+1;
//            count2 = (end - maxindex)+1;
//        }
//        else{
//            // maxindex- left and minindex - right
//            count1 = (end - minindex)+1;
//            count2 = (maxindex - start)+1;
//        } 
//        //}
//        return count1+count2;
//        //return minindex;
		int max=nums[0], min=nums[0], minindex=0, maxindex=0, temp=0, n = nums.length;
		if(n==1)
			return 1;
        for(int i=1; i<n; i++){
            if(nums[i] > max){
                max = nums[i];
                maxindex = i;
            }
            if(nums[i] < min){
                min = nums[i];
                minindex = i;
            }
        }
        //int start=0, end=n-1, count1=0, count2=0;
        int start=0, end=n-1, count1=0, count2=0;
        if((minindex <= n/2) && (maxindex <= n/2)){
            count1 = minindex - start;
            count2 = maxindex - start;
            return count1+count2;
        }
        if((minindex >= n/2) && (maxindex >= n/2)){
            count1 = end - minindex;
            count2 = end - maxindex;
        }
        if((minindex <= n/2) && (maxindex >= n/2)){
            count1 = (minindex - start)+1;
            count2 = (end - maxindex)+1;
        }
        if((minindex >= n/2) && (maxindex <= n/2)){
            // maxindex- left and minindex - right
            count1 = (end - minindex)+1;
            count2 = (maxindex - start)+1;
        } 
	int ans = count1+count2;
        return ans;
    }
}
