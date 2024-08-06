int[] freq = new int[26];
        for(int i = 0;i < word.Length;i++){
            char c = word[i];
            freq[c - 'a']++;
        }
        Array.Sort(freq,(a,b) => b - a);
        int res = 0;
        for(int i = 0;i < freq.Length;i++){
            if(freq[i] == 0) break;
            int pushes = i / 8 + 1;
            res+= (pushes * freq[i]);
        }
        return res;
