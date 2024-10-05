using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation.TreeImplementation;

namespace TreeImplementation.MaxLEvelNodes
{
    public class MaxLevelNodesClass
    {
        public int FindMaxLevelNodes(TNode root)
        {
            if (root == null)
                return -1; 
            List<TNode> currentLevelNodes = new List<TNode> { root };
            int maxNodes = 0;
            int maxLevel = 0;
            int currentLevel = 0;

            while (currentLevelNodes.Count > 0)
            {
                int levelNodeCount = currentLevelNodes.Count;

                if (levelNodeCount > maxNodes)
                {
                    maxNodes = levelNodeCount;
                    maxLevel = currentLevel;
                }

                List<TNode> nextLevelNodes = new List<TNode>();

                foreach (var node in currentLevelNodes)
                {
                    if (node.Left != null)
                    {
                        nextLevelNodes.Add(node.Left);
                    }
                    if (node.Right != null)
                    {
                        nextLevelNodes.Add(node.Right);
                    }
                }
                currentLevelNodes = nextLevelNodes;
                currentLevel++;
            }

            return maxLevel;
        }
    }
}
