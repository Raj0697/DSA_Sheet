package pattern_Programs;

public class Pattern1 {
	
	public static void main(String[] args)
	{
		/*

		 * * * * *
		 * * * *
		 * * *
		 * *
		 * 

		 */
//		for(int row=5; row >= 1; row--)
//		{
//			for(int col=1; col <= row; col++)
//			{
//				System.out.print("* ");
//			}
//			System.out.println();
//		}
		int n=5;
		for(int row=1; row <= n; row++)
		{
			for(int col=1; col <= (n+1-row); col++) // n+1-row = 5+1-1 = 5
			{
				System.out.print("* ");
			}
			System.out.println();
		}
		
		/*
		 * * * * *
		 * * * * * 
		 * * * * * 
		 * * * * * 
		 * * * * * 
		 */
		System.out.println();
		for(int row=1; row <= 5; row++)
		{
			for(int col=1; col <=5; col++)
			{
				System.out.print("* ");
			}
			System.out.println();
		}
		/*
		 
		 * 
		 * * 
		 * * *
		 * * * *
		 * * * * *

		 */
		System.out.println();
		for(int row = 1; row <= 5; row++)
		{
			for(int col = 1; col <= row; col++)
			{
				System.out.print("* ");
			}
			System.out.println();
		}
		
		System.out.println();
		for(int row = 1; row <= 5; row++)
		{
			for(int col = 1; col <= row; col++)
			{
				System.out.print(col+" ");
			}
			System.out.println();
		}
	}
}
