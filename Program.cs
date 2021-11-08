using System;
using System.Collections;

namespace UniqueBinarySearchTrees_11._8._21_CM
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int totalBinarySearchTrees = NumTrees(20);

                Console.WriteLine(totalBinarySearchTrees);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error has occurred: " + ex.Message);
            }
        }

        public static int NumTrees(int n)
        {
            if (n < 1 || n > 19)
            {
                throw new Exception("Number cannot be smaller than 1 or larger than 19.");
            }
            else
            {
                ArrayList binarySearchTrees = constructTrees(1, n);
                return binarySearchTrees.Count;
            }
        }

        public static ArrayList constructTrees(int start, int end)
        {
            ArrayList list = new ArrayList();

            if (start > end)
            {
                list.Add(null);
                return list;
            }

            for (int i = start; i <= end; i++)
            {
                ArrayList leftSubtree = constructTrees(start, i - 1);

                ArrayList rightSubtree = constructTrees(i + 1, end);

                for (int j = 0; j < leftSubtree.Count; j++)
                {
                    Node left = (Node)leftSubtree[j];

                    for (int k = 0; k < rightSubtree.Count; k++)
                    {
                        Node right = (Node)rightSubtree[k];

                        Node node = new Node(i);

                        node.left = left;

                        node.right = right;

                        list.Add(node);
                    }
                }
            }

            return list;
        }

        public class Node
        {
            public int key;
            public Node left, right;
            public Node(int data)
            {
                key = data;
                left = right = null;
            }
        }
    }
}
