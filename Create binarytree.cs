var tree = new Dictionary<int, TreeNode>();
        var sonsSet = new HashSet<int>();
        foreach(var desc in descriptions) {
            var val = desc[0];
            if(!tree.ContainsKey(val)) {
                tree[val] = new TreeNode(val);
            }
            var son = desc[1];
            sonsSet.Add(son);

            if(!tree.ContainsKey(son)) {
                tree[son] = new TreeNode(son);
            }
            if(desc[2] == 1) {
                tree[val].left = tree[son];
            }
            else {
                tree[val].right = tree[son];
            }
        }
        TreeNode ret = null;
        foreach(var kvp in tree) {
            if(!sonsSet.Contains(kvp.Key)) {
                ret = kvp.Value;
            }
        }

        return ret;
