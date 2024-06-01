public sealed class Solution 
{
    public int ScoreOfString(string s) =>

        Enumerable
            .Zip(s, s.Skip(1), (a, b) => Math.Abs(a - b))
            .Sum(); 
}
