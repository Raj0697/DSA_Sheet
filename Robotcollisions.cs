var dictionary = new Dictionary<int, int>();
        for (var i = 0; i < positions.Length; i++)
        {
            dictionary.Add(positions[i], i);
        }

        Array.Sort(positions);
        var stack = new Stack<int>();
        for (var i = 0; i < positions.Length; i++)
        {
            var position = positions[i];
            var index = dictionary[position];
            while (stack.Count > 0 && directions[stack.Peek()] == 'R' && directions[index] == 'L' && healths[index] > 0)
            {
                var last = stack.Peek();
                if (healths[last] < healths[index])
                {
                    stack.Pop();
                    healths[index]--;
                    healths[last] = 0;
                }
                else if (healths[last] > healths[index])
                {
                    healths[last]--;
                    healths[index] = 0;
                }
                else
                {
                    stack.Pop();
                    healths[last] = 0;
                    healths[index] = 0;
                }
            }
            if (healths[index] > 0)
            {
                stack.Push(index);

            }
        }
        var list = new List<int>();

        foreach (var health in healths)
        {
            if (health > 0)
                list.Add(health);
        }
        return list;
