package sde_sheet;

public class Even_odd_using_operators {

	public static void main(String[] args) {
		int n = 78;
		//int[] nums = {12,143,7896,3,5};
		int[] nums = {12,345,2,6,7896};
		System.out.println(isevenodd(n));
		int temp = 0, n2 = nums.length, c = 0;
//        for(int i=0; i<n2; i++) {
//            nums[i] /= 10;
//            ++temp;
//        }
//        System.out.println(temp);
//        for(int i=0; i<n2; i++) {
//	        if((String.valueOf(nums[i]).length())%2==0) {
//	        	temp += 1;
	        }
        }
        System.out.println(temp);
        for(int i=0; i<nums.length; i++) {
            //return nums[i].length & 1;
        	//(String.valueOf(nums[i]).length()) & 1
        }
	}
	
	public static boolean isevenodd(int n) {
		
		return (n & 1) == 1;
	}
}
