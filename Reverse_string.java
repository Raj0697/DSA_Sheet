package sde_sheet;

public class Reverse_string {
	
	public static void main(String[] args) {
		char[] s = {'h', 'e', 'l','l','o'};
		System.out.print(_reverse(s) + " ");
	}
	
	public static void swap(char[] s, int n1, int n2) {
		char t = s[n1];
        s[n1] = s[n2];
        s[n2] = t;
	}
	public static void _reverse(char[] s) {
		//int start = 0, end = s.length-1;
        //while(start < end){
          //  swap(s, start, end);
            //start++;
            //end--;
        //}
        //for(char c : s)
          //  System.out.print(c);
        //System.out.println();
        
        for(int i=0;i<s.length/2;i++){
            swap(s, i,s.length-1-i);
        }
	}s
}
