private void Swap<T>(ref T A, ref T B) {
        T temp = A;
        A = B;
        B = temp;
    }

    public string[] SortPeople(string[] names, int[] heights) {
        int n = names.Length - 1;
        for(int i = n; i >= 0; i--) {
            for(int j = n; j > n - i; j--) {
                if(heights[j] > heights[j - 1]) {
                    Swap(ref heights[j], ref heights[j - 1]);
                    Swap(ref names[j], ref names[j - 1]);
                }
            }
        }
        
        return names;
    }
