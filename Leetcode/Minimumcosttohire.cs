public class Solution {
    public double MincostToHireWorkers(int[] quality, int[] wage, int k) {
        var workers = new double[quality.Length][];

        for (var i = 0; i < quality.Length; ++i)
        {
            workers[i] = [(double)wage[i] / quality[i], quality[i]];
        }

        Array.Sort(workers, (a, b) => a[0].CompareTo(b[0]));

        var result = double.MaxValue;
        double sum = 0;
        var pq = new PriorityQueue<double, double>();
        
        foreach (var worker in workers)
        {
            sum += worker[1];

            pq.Enqueue(-worker[1], -worker[1]);

            if (pq.Count > k)
            {
                sum += pq.Dequeue();
            }

            if (pq.Count == k)
            {
                result = Math.Min(result, sum * worker[0]);
            }
        }

        return result;
    }
}
