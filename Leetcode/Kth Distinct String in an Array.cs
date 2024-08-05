var dict = new Dictionary<string, int>();
        
        foreach (string str in arr) {
            if (dict.ContainsKey(str)) dict[str]++;
            else dict[str] = 1;
        }
        
        foreach (string str in arr) {
            int count;
            if (dict.TryGetValue(str, out count)) {                
                if (count == 1) {                    
                    if (--k == 0) return str;                    
                }
            }            
        }
        
        return "";
