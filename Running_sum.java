package sde_sheet;

public class Running_sum {

	public static void main(String[] args) {
		int[] ar = {1,2,3,4};
		RunningSum(ar);
		//System.out.print(RunningSum(ar)+" ");
		System.out.println(RunningSum(ar));
	}
	
	public static int[] RunningSum(int[] nums) {
        int[] ar = new int[nums.length];
        int sum = 0;
        for(int i=0; i<nums.length; i++) {
        	sum += nums[i];
        	ar[i] = sum;
        }
        return ar;
    }
}
