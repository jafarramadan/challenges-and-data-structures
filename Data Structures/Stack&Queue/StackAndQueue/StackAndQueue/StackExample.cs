using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class StackExample
    {
        private Node top;

        public StackExample()
        {
            top = null;
        }
        
        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = top;
            top = newNode;
        }
        
        public int Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("stack is empty");
            }

            int data = top.Data;
            top = top.Next;
            return data;
        }
        
        public int Peek()
        {
            if (IsEmpty())
            {
                throw new Exception("stack is empty");
            }
            return top.Data;
        }

        
        public bool IsEmpty()
        {
            return top == null;
        }

        public int Countt(StackExample stackk)
        {
           int count = 0;
            while (stackk.IsEmpty() == false)
            {
                count++;
                stackk.Pop();
            }
            return count;
        }

        public void PrintStack(StackExample stack)
        {
            while (stack.IsEmpty() == false)
            {
                Console.WriteLine(stack.Pop());
            }
        }

        public void Top(StackExample stack)
        {
            Console.WriteLine(stack.Peek());
        }
    }
}
