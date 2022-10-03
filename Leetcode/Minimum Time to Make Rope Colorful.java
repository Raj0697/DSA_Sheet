class Solution {
    public int minCost(String colors, int[] neededTime) {
        int time = 0;
        int i = 0;
        while(i < colors.length()) {
            char c = colors.charAt(i);
            int max = neededTime[i++];
            time += max;
            while(i < colors.length() && colors.charAt(i) == c) {
                max = Math.max(neededTime[i], max);
                time += neededTime[i++];
            }
            time -= max; // if there are more than 1 repeating element , max time will be removed(element with max time will be spared)
        }
        return time;
    }
}
