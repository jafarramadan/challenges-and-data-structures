using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation.TreeImplementation;

namespace TreeImplementation.SecondMaxValue
{
    public class SecondMaxValueClass
    {
        public int FindSecondMax(TNode root)
        {
            if (root == null)
            {
                throw new InvalidOperationException("Tree is empty");
            }

            TNode parent = null;
            TNode current = root;

            while (current.Right != null)
            {
                parent = current;
                current = current.Right;
            }
            if (current.Left != null)
            {
                return FindMax(current.Left);
            }

            if (parent != null)
            {
                return parent.Value;
            }
            throw new InvalidOperationException("No second maximum value found");
        }

        private int FindMax(TNode node)
        {
            TNode current = node;

            while (current.Right != null)
            {
                current = current.Right;
            }

            return current.Value;
        }
    }
}