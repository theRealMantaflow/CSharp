namespace treeDS
{
    /// <summary>
    /// Binary Tree Node
    /// </summary>
    /// <typeparam name="T">Datatype of element</typeparam>
    public class TreeNode<T>
    {
        public T Data { get; set; }
        public TreeNode<T>? LChild { get; set; }
        public TreeNode<T>? RChild { get; set; }
        /// <summary>
        /// Constructer Initialization
        /// </summary>
        /// <param name="data">Value of data to be stored</param>
        public TreeNode(T data)
        {
            Data = data;
            LChild = null;
            RChild = null;
        }
    }
    
    public class Tree<T>
    {
        public TreeNode<T>? Root { get; set; }
        public Tree(T rootData)
        {
            Root = new TreeNode<T>(rootData);
        }
    }

    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter the root: ");
            int a;
            int.TryParse(Console.ReadLine(), out a);
            Tree<int> root = new Tree<int>(a);

            GetElements(root.Root);

            Console.WriteLine("The tree in InOrder:");
            InOrder(root.Root);
        }

        /// <summary>
        /// Gets the elements in the order Left Child, Right Child
        /// </summary>
        /// <param name="root">Root Node</param>
        static void GetElements(TreeNode<int> root)
        {
            Console.WriteLine("Enter Left Child:");
            string ld;
            ld = Console.ReadLine();
            if (ld != "s")
            {
                int lid=int.Parse(ld);
                root.LChild = new TreeNode<int>(lid);
                GetElements(root.LChild);
            }

            Console.WriteLine("Enter Right Child:");
            string rd;
            rd = Console.ReadLine();
            if (rd != "s")
            {
                int rid = int.Parse(rd);
                root.RChild = new TreeNode<int>(rid);
                GetElements(root.RChild);
            }
        }

        static void InOrder(TreeNode<int> root)
        {
            if (root == null)
                return;
            InOrder(root.LChild);
            Console.WriteLine(root.Data.ToString()+" ");
            InOrder(root.RChild);
        }
    }
}