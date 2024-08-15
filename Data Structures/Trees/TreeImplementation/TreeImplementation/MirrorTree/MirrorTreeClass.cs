using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation.TreeImplementation;

namespace TreeImplementation.MirrorTree
{
    public class MirrorTreeClass
    {
        List<int> list = new List<int>();
        public List<int> InorderTraversal(TNode node)
        {
            if (node == null) return null;
            InorderTraversal(node.Left);
            list.Add(node.Value);
            InorderTraversal(node.Right);
            return list;
        }

        public List<int> Merror(List<int> node)
        {
            node.Reverse();
            return list;
        }
    }
}