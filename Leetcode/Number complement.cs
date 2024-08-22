int i = 1;
	while (i < num)
		i = i | (i << 1);
	return ~num & i;
