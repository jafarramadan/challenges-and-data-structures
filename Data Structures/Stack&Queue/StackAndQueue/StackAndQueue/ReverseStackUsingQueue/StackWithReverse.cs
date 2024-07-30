using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue.ReverseStackUsingQueue
{
    public class StackWithReverse : StackExample
    {
        public StackExample ReverseStack(StackExample stack1)
        {
            QueueExample queue1 = new QueueExample();

            while (stack1.IsEmpty()==false)
            {
                queue1.Enqueue(stack1.Pop());
            }

            while(queue1.IsEmpty() == false)
            {
                stack1.Push(queue1.Dequeue());
            }
            
            return stack1;
        }

    }
}
