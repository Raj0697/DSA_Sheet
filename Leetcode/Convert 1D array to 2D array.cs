if (original.Length != m * n)
		return Array.Empty<int[]>();

	var array = new int[m][];
	var index = 0;

	for (var i = 0; i < m; i++)
	{
		array[i] = new int[n];
		for (var j = 0; j < n; j++)
		{
			array[i][j] = original[index++];
		}
	}

	return array;
