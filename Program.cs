namespace _112._Path_Sum
{
    internal class Program
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null) return false;
            if (root.left == null && root.right == null && targetSum == root.val) return true;
            return HasPathSum(root.left,targetSum - root.val) || HasPathSum(root.right,targetSum - root.val);
    }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}