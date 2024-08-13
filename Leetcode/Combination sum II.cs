public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
      
        List<IList<int>> res = new List<IList<int>>();
        Array.Sort(candidates);
        Backtracking(candidates, target, 0, new List<int>(), res);
        return res;
    }
    
    private void Backtracking(int[] candidates, int target, int start, List<int> list, List<IList<int>> res)
    {
        if(target < 0)
            return;
        else if(target == 0)
        {
            res.Add(new List<int>(list));
            return;
        }
        else
        {
            for(int i = start; i < candidates.Length; i++)
            {
                if(i > start && candidates[i] == candidates[i - 1])
                    continue;
                
                list.Add(candidates[i]);
                Backtracking(candidates, target - candidates[i], i + 1, list, res);
                list.RemoveAt(list.Count - 1);
            }
        }
    }
