package sde_sheet;

public class Move_Zeroes {
	
	public static void main(String[] args) {
		int[] nums = {0,1,0,3,12};
		//moveZeroes(ar);
		//System.out.println(moveZeroes(ar));
		
	    int c =0;
	    
	    for(int i=0;i<nums.length;i++){
	        
	        if(nums[i]!=0){
	            nums[c]=nums[i];
	            c++;
	            
	        }
	        
	        
	    }
	    while(c<nums.length){
	        nums[c]=0;
	        c++;
	    }
	    System.out.println(nums);
	}
	
//	public static int[] moveZeroes(int[] nums) {
//        int start = 0, end = nums.length-1;
//        for(int i=0; i<end; i++) {
//        	if(nums[i] == 0) {
//        		swap(start, end, nums);
//        		start++;
//        		end--;
//        	}
//        }
//        while(start < end){
//        	
//        	if(nums[])
////            for(int i=0; i<end; i++){
////                if(nums[i] == 0){
////                    swap(start, end, nums);
////                    start++;
////                    end--;
////                }
////            }
//        }
//        for(int i=0; i<end; i++){
//            System.out.print(nums+ "");
//        }
        //System.out.println();
//        return nums;
//    }
//    public static void swap(int n1, int n2, int[] ar){
//        int t = ar[n1];
//        ar[n1] = ar[n2];
//        ar[n2] = t;
//    }
}
