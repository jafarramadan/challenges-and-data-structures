using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation.TreeImplementation;

namespace TreeImplementation.LeafSum
{
    public class Leaf_SumClass 
    {
        public int SumLeaf(TNode node)
        {
            if (node == null) return 0;
            if (node.Left == null && node.Right == null) return node.Value;
            return  SumLeaf(node.Left) + SumLeaf(node.Right);

        }
    }
}
