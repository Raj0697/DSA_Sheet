public class Solution {
    public int NumWaterBottles(int numBottles, int numExchange) {
        int full = numBottles, empty = numBottles;
        
        while(empty >= numExchange)
        {
            full += empty/numExchange;
            empty = empty/numExchange + empty%numExchange;
        }
        
        return full;
    }
}
