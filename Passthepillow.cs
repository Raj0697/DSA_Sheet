public class Solution {
    public int PassThePillow(int n, int time) {
        int m = time % (n+n-2);
        return 1 + (m<n ? m : (n+n-2)-m);
    }
}
