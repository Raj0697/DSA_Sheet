/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node(){}
    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
}
*/
public class Solution {
    public IList<int> Postorder(Node root)
        {
            var nodes = new List<int>();
            if (root == null)
                return nodes;

            postorderTraversal(root, nodes);

            return nodes;
        }

        /// <summary>
        /// assume root is not null
        /// </summary>
        /// <param name="root"></param>
        /// <param name="nodes"></param>
        private static void postorderTraversal(Node root, List<int> nodes)
        {           
            if (root.children == null)
                return;

            foreach (var item in root.children)
            {
                postorderTraversal(item, nodes);
            }

            nodes.Add(root.val);
        }
}
