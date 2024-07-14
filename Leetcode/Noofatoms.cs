int n = formula.Length;
        Stack<Dictionary<string, int>> stack = new Stack<Dictionary<string, int>>();
        Dictionary<string, int> map = new Dictionary<string, int>();
        int i = 0;
        
        while (i < n) {
            char ch = formula[i];
            
            if (ch == '(') {
                // Push current map to stack and start a new map
                stack.Push(map);
                map = new Dictionary<string, int>();
                i++;
            } else if (ch == ')') {
                // Pop map from stack and merge with current map
                i++;
                int start = i;
                int multiplicity = 1;
                if (i < n && Char.IsDigit(formula[i])) {
                    while (i < n && Char.IsDigit(formula[i])) i++;
                    multiplicity = int.Parse(formula.Substring(start, i - start));
                }
                
                if (stack.Count > 0) {
                    Dictionary<string, int> tempMap = map;
                    map = stack.Pop();
                    foreach (var key in tempMap.Keys) {
                        if (map.ContainsKey(key)) {
                            map[key] += tempMap[key] * multiplicity;
                        } else {
                            map[key] = tempMap[key] * multiplicity;
                        }
                    }
                }
            } else {
                int start = i;
                i++;
                while (i < n && Char.IsLower(formula[i])) i++;
                string element = formula.Substring(start, i - start);
                start = i;
                while (i < n && Char.IsDigit(formula[i])) i++;
                int count = start < i ? int.Parse(formula.Substring(start, i - start)) : 1;
                if (map.ContainsKey(element)) {
                    map[element] += count;
                } else {
                    map[element] = count;
                }
            }
        }
        
        // Sort the elements and build the final string
        SortedDictionary<string, int> sortedMap = new SortedDictionary<string, int>(map);
        StringBuilder result = new StringBuilder();
        foreach (var entry in sortedMap) {
            result.Append(entry.Key);
            if (entry.Value > 1) {
                result.Append(entry.Value);
            }
        }
        
        return result.ToString();
