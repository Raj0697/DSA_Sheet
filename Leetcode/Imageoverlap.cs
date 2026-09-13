public int LargestOverlap(int[][] img1, int[][] img2)
{
	int n = img1.Length;

	List<(int, int)> ones1 = new();
	List<(int, int)> ones2 = new();
	Dictionary<(int, int), int> freq = new();

	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < n; j++)
		{
			if (img1[i][j] == 1) ones1.Add((i, j));
			if (img2[i][j] == 1) ones2.Add((i, j));
		}
	}

	foreach (var (i, j) in ones1)
	{
		foreach (var (k, l) in ones2)
		{
			var dist = (i - k, j - l);
			if (!freq.ContainsKey(dist)) freq[dist] = 0;
			freq[dist]++;
		}
	}

	return freq.Count > 0 ? freq.Values.Max() : 0;
}