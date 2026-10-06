public class Solution {
    public int MinAddToMakeValid(string s) {
          var count = 0;
  var result = 0;

  foreach (var ch in s)
  {
      if (ch == '(')
          count++;
      else
      {
          if (count == 0) result++;
          else count--;
      }
  }

  return result + count;
    }
}