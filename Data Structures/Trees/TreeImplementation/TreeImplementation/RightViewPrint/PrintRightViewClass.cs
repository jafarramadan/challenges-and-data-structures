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
       public void PrintRightView(TNode node)
        {
            TNode current = node.Left;
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Right;
            }

            while (current != null)
            {
                Console.WriteLine(current.Value);
                if (current.Value == null)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
            }
        }
    }
}






