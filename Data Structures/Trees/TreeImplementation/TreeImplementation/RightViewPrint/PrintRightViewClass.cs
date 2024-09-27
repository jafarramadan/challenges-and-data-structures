using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TreeImplementation.TreeImplementation;

namespace TreeImplementation.RightViewPrint
{
    public class PrintRightViewClass
    {
        public List<int> PrintRightView(TNode node)
        {
            List<int> rightViewList = new List<int>();

            if (node == null) return rightViewList;
            if (node.Right == null ||  node.Left == null)return rightViewList;
            
            List<TNode> nodeList = new List<TNode>();
            nodeList.Add(node); 

            while (nodeList.Count > 0)
            {
                int levelSize = nodeList.Count;
                int count = 0;  

                while (count < levelSize)
                {
                    TNode current = nodeList[0];
                    nodeList.RemoveAt(0);
                    count++;

                    if (count == levelSize)
                    {
                        rightViewList.Add(current.Value);
                    }
                    if (current.Left != null)
                    {
                        nodeList.Add(current.Left);
                    }
                    if (current.Right != null)
                    {
                        nodeList.Add(current.Right);
                    }
                }
            }
            return rightViewList;
        }

       
    }
}