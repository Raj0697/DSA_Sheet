package sde_sheet;

public class ValidPerfectsquare {
	
	public static void main(String[] args) {
		System.out.println(perfectsquare(9));
	}

	public static boolean perfectsquare(int num) {
		int start=0, end=num/2;
		if(num == 0 || num == 1)
			return true;
		while(start <= end) {
			int mid = start + (end - start) / 2;
			if(mid * mid == num)
				return true;
			else if(mid * mid < num)
				start = mid + 1;
			else
				end = mid - 1;
		}
		return false;
	}
}
