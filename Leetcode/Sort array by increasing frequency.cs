var freqMap = new Dictionary<int, int>();
        foreach (var num in nums) {
            if (freqMap.ContainsKey(num)) {
                freqMap[num]++;
            } else {
                freqMap[num] = 1;
            }
        }

        // Step 2: Group elements by their frequency
        var groupedByFreq = new Dictionary<int, List<int>>();
        foreach (var kvp in freqMap) {
            var num = kvp.Key;
            var freq = kvp.Value;
            if (!groupedByFreq.ContainsKey(freq)) {
                groupedByFreq[freq] = new List<int>();
            }
            groupedByFreq[freq].Add(num);
        }

        // Step 3: Sort the groups by frequency and sort the elements in each group in descending order
        var sortedNums = new List<int>();
        foreach (var freq in groupedByFreq.Keys.OrderBy(f => f)) {
            var numsWithSameFreq = groupedByFreq[freq];
            numsWithSameFreq.Sort((a, b) => b.CompareTo(a)); // Descending order
            foreach (var num in numsWithSameFreq) {
                for (int i = 0; i < freq; i++) {
                    sortedNums.Add(num);
                }
            }
        }

        return sortedNums.ToArray();
