using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class MinStack : StackExample
    {
        public int GetMin(StackExample stack )
        {
            List<int> temp = new List<int>();
            while (stack.IsEmpty()==false)
            {
                
                temp.Add(stack.Pop());
            }
            int min=temp.Min();
            return min;
        }
    }
}
