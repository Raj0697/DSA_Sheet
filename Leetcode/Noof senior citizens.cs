public class Solution {
    public int CountSeniors(string[] details) {
        var count = 0;

        foreach (var detail in details)
        {
            var age = int.Parse(detail.Substring(11, 2));
            if (age > 60)
                count++;
        }

        return count;
    }
}
