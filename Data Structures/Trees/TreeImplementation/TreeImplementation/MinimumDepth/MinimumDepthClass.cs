using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation.TreeImplementation;

namespace TreeImplementation.MinimumDepth
{
    public class MinimumDepthClass
    {
        public int FindMinimumDepth(TNode Root)
        {
            if (Root == null)
                return 0; 

            Queue<TNode> queue = new Queue<TNode>();
            queue.Enqueue(Root);
            int depth = 1;

            while (queue.Count > 0)
            {
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    TNode currentNode = queue.Dequeue();
                    if (currentNode.Left == null && currentNode.Right == null)
                        return depth;
                    if (currentNode.Left != null)
                        queue.Enqueue(currentNode.Left);

                    if (currentNode.Right != null)
                        queue.Enqueue(currentNode.Right);
                }
                depth++;
            }

            return depth;
        }
    }
}
