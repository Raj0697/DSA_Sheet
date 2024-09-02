long[] prefixSum = new long[chalk.Length];
        long cur = 0;
        for (int i = 0; i < chalk.Length; ++i)
        {
            cur += chalk[i];
            prefixSum[i] = cur;
        }
        int index = Array.BinarySearch(prefixSum, k % cur);
        return index >= 0 ? index + 1 : ~index;
