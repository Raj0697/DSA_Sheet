public class exam
{
  public int sumofleaves(){
int sum = 0;
            if (root == null)
                return 0;

            if (root.left != null &&
                root.left.left == null &&
                root.left.right == null)
                sum += root.left.val;

            sum+=SumOfLeftLeaves(root.left);
            sum+=SumOfLeftLeaves(root.right);
            return sum;
  }
}
