public class Solution {
    public int FindMinArrowShots(int[][] p) {
        if(!p.Any()) { return 0; }
        
        var points = p.OrderBy(x => x[1]);
        int result = 1;
        int lastArrowXPosition = points.First().Last();
        
        foreach(var x in points.Skip(1))
        {
            if(x[0] > lastArrowXPosition) 
            {
                result++;
                lastArrowXPosition = x[1];
            }
        }
        
        return result;
    }
}
