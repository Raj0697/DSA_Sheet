class Solution {
    public int[] plusOne(int[] digits) {
        int n = digits.length - 1;
        for(int i=n; i>=0; i--) {
            if(digits[i] < 9) {
                digits[i] += 1;
                return digits;
            }
            else if(digits[i] == 9 && i != 0)
                digits[i] = 0;
            else
                break;
        }
        int[] ar = new int[digits.length + 1];
        ar[0] = 1;
        return ar;
    }
}
