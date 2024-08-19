private int minSteps = Int32.MaxValue;
    
    public int MinSteps(int n) {
        if (n == 1) return 0; // no work needed, already there
        
        DFS(n, 1, 1, 1);
        return minSteps;
    }
    
    public void DFS(int n, int curr, int steps, int previousCopy) {
        if (curr > n) return; // no allowed
        if (curr == n) {
            minSteps = Math.Min(minSteps, steps);
            return;
        }
        
        // two choices to take
        // 1. use the previous copy, just one step here
        DFS(n, curr+previousCopy, steps+1, previousCopy);
        // 2. create a new copy-paste, two steps, copy-all and then paste
        DFS(n, curr*2, steps+2, curr);
    }
