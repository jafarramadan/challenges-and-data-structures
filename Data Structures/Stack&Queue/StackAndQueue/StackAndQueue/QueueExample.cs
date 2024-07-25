using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class QueueExample
    {
        public Node front;
        public Node back;

        public QueueExample()
        {
            front = back = null;
        }
        public void Enqueue(int data)
        {
            Node newNode = new Node(data);

            if (IsEmpty())
            {
                front = back = newNode;
            }
            else
            {
                back.Next = newNode;
                back = newNode;
            }
        }
        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new Exception("Queue is empty");
            }
            else
            {
               int data  = front.Data;
                front=front.Next;

                if (IsEmpty())
                {
                    back = null;
                }
                return data;    
            }
        }

        public int Peek()
        {
            return front.Data;
        }

        public bool IsEmpty()
        {
            return front == null;
        }
    }
}
