package sde_sheet;

import java.util.Arrays;

public class Twodimensionalarray {
	
	public static void main(String[] args)
	{
		int[][] arr = {
				{1, 2, 3, 4},
				{5, 6, 7, 8},
				{9, 7, 3, 0}
		};
		System.out.println(arr.length);
		for(int row=0; row<arr.length; row++)
		{
			for(int col=0; col<arr[row].length; col++)
			{
				//System.out.print(arr[row][col] + " ");
				//System.out.print(Arrays.toString(arr[row]));
			}
			//System.out.println();
		}
		for(int[] a : arr) {
			System.out.println(Arrays.toString(a));
		}
	}
}