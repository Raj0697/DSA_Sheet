package sde_sheet;

import java.util.Arrays;
import java.util.HashSet;
import java.util.Set;

public class Sumoftwonums {
	public static boolean solve(int[] nums, int k) {
		Set<Integer> set = new HashSet<>();
		for(int i=0; i<nums.length; i++) {
			if(set.contains(k - nums[i])) {
				return true;
			}
			else {
				set.add(nums[i]);
			}
		}
		return false;
	}
	
	public static void reverseWord(String str)
    {
        int start = 0;
        char[] ch=str.toCharArray();
        int end = ch.length - 1;
        while(start < end){
            swap(ch, start, end);
            start++;
            end--;
        }
        for(char c : ch)
        	System.out.print(c);
        System.out.println();
    }
    
    public static void swap(char[] strr, int index1, int index2)
    {
        char temp = strr[index1];
        strr[index1] = strr[index2];
        strr[index2] = temp;
    }
	
	public static void main(String[] args) {
		int[] arr = {35, 8, 18, 3, 22};
		System.out.println(solve(arr, 11));
		reverseWord("geeks");
	}
}
