using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation.TreeImplementation;

namespace TreeImplementation.LargestLevelValue
{
    public class LargestLevelValueClass
    {
        public  List<int> LargestLevelValue(BinaryTree tree)
        {
            List<int> largestValues = new List<int>();

            if (tree.Root == null)
            {
                return largestValues; 
            }

            Queue<TNode> queue = new Queue<TNode>();
            queue.Enqueue(tree.Root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;
                int maxValue = int.MinValue;

                for (int i = 0; i < levelSize; i++)
                {
                    TNode currentNode = queue.Dequeue();
                    if (currentNode.Value > maxValue)
                    {
                        maxValue = currentNode.Value;
                    }

                    if (currentNode.Left != null)
                    {
                        queue.Enqueue(currentNode.Left);
                    }

                    if (currentNode.Right != null)
                    {
                        queue.Enqueue(currentNode.Right);
                    }
                }

                largestValues.Add(maxValue);
            }
            
            return largestValues;
        }
    }
}
