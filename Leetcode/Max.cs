public int MaxScoreWords(string[] words, char[] letters, int[] score) {
        int[] arr = new int[26];
        for(int i = 0; i < letters.Length; i++){
            arr[letters[i] - 'a'] ++;
        }
        return BC(words, arr, score, 0);
    }
    private int BC(string[] words, int[] letters, int[] scores, int i){
        if(i >= words.Length) return 0;
        int score = 0;
        int[] newLetters = new int[26];
        for(int j = 0; j < 26; j ++){
            newLetters[j] = letters[j];
        }
        foreach(var c in words[i]){
            if(newLetters[c - 'a'] > 0){
                newLetters[c - 'a']--;
                score+= scores[c - 'a'];
            }
            else{
                score = -1;
                break;
            }
        }
        int a = 0;
        if(score >= 0){
            a = score + BC(words, newLetters, scores, i + 1);
        }
        int b = BC(words, letters, scores, i + 1);
        return Math.Max(a , b);
    }
