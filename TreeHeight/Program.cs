using System;

namespace TreeHeight
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 7, 10, 12, 6, 8 };
            Node root = null;

            foreach (var item in arr)
            {
                root = Tree.Insert(root, item);
            }

            Console.WriteLine("Tree height is : " +
                                        Tree.CalculateDepth(root));
        }
    }
}
