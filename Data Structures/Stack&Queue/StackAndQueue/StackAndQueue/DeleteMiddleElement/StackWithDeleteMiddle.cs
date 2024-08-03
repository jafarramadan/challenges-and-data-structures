using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue.DeleteMiddleElement
{
    public class StackWithDeleteMiddle
    {
        public StackExample DeleteMiddle(StackExample stack)
        {
            StackExample stack2= new StackExample();
            int count = 0;
            while (stack.IsEmpty()==false)
            {
                count++;
                stack2.Push(stack.Pop());
            }
            int middle = 0;
            if (count % 2 == 0)
            {
                 middle=count/2;
            }
            else
            {
                 middle = count / 2+1;

            }
            int count2 = 0;
            while (stack2.IsEmpty() == false)
            {
                count2++;
                if (count2== middle)
                {
                    stack2.Pop();
                }
                else
                {
                    stack.Push(stack2.Pop());

                }

            }
            return stack;
        }
    }
}
