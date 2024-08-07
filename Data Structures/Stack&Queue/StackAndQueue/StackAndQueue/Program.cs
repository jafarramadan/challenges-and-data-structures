using StackAndQueue.DeleteMiddleElement;
using StackAndQueue.ReverseStackUsingQueue;

namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====Stack========================================================");
            StackExample stack = new StackExample();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            Console.WriteLine("Adding 1,2,3,4");
            Console.WriteLine($"The popped element is : {stack.Pop()}");
            Console.WriteLine($"The Peeked element is : {stack.Peek()}");
            Console.WriteLine($"Check if stack is empty ? {stack.IsEmpty()}");

            //==========================================================

            Console.WriteLine("====Queueu========================================================");
            QueueExample queue = new QueueExample();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            Console.WriteLine("Adding 1,2,3,4");
            Console.WriteLine($"The Dequeued element is : {queue.Dequeue()}");
            Console.WriteLine($"The Peeked element is : {queue.Peek()}");
            Console.WriteLine($"Check if queue is empty ? {queue.IsEmpty()}");



            //==========================================================

            Console.WriteLine("====ReversStack========================================================");
            StackWithReverse reverse = new StackWithReverse();
            StackExample stack1 = new StackExample();
            stack1.Push(1);
            stack1.Push(2);
            stack1.Push(3);
            stack1.Push(4);
            Console.WriteLine("Print the stack after reversing");
            reverse.ReverseStack(stack1);
            while (stack1.IsEmpty() == false)
            {
                Console.WriteLine(stack1.Pop());
            }

          //  =================================================================================
            Console.WriteLine("====StackWithDeleteMiddle========================================================");

            StackWithDeleteMiddle s = new StackWithDeleteMiddle();  
            StackExample stack2 = new StackExample();

            stack2.Push(7);
            stack2.Push(14);
            stack2.Push(3);
            stack2.Push(8);
            stack2.Push(5);
            s.DeleteMiddle(stack2);
            Console.WriteLine("Print the stack Stack With Delete Middle");

            while (stack2.IsEmpty()==false)
            {
                Console.WriteLine(stack2.Pop());
            }


            //  =================================================================================
            Console.WriteLine("====MinStack========================================================");
            MinStack minStack = new MinStack();
            StackExample stack3 = new StackExample();
            stack3.Push(15);
            stack3.Push(7);
            stack3.Push(12);
            stack3.Push(3);

            Console.WriteLine("The min element in the stack is : "+minStack.GetMin(stack3));

        }
    }
}