class Solution {
    public boolean checkIfPangram(String sentence) {
        if(sentence.length() <26)
            return false;
        String alpha = "abcdefghijklmnopqrstuvwxyz";
        for(int i=0; i<alpha.length(); i++) {
            if(sentence.indexOf(alpha.charAt(i)) == -1) {
                return false;
            }
        }
        return true;
    }
}
