IList<TreeNode> result = new List<TreeNode>();
    HashSet<int> hashSet;
    
    public IList<TreeNode> DelNodes(TreeNode root, int[] to_delete) 
    {
        hashSet = new HashSet<int>(to_delete);
        Delete(root, null);
        return result;
    }

    TreeNode Delete(TreeNode root, TreeNode parent) 
    {
        if (root == null) return null;
        var current = hashSet.Contains(root.val) ? null : root;
        root.left = Delete(root.left, current);
        root.right = Delete(root.right, current);
        if (parent == null && current != null) result.Add(current);
        return current;
    }
