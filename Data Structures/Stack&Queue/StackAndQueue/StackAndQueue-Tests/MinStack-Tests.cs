using StackAndQueue.ReverseStackUsingQueue;
using StackAndQueue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace StackAndQueue_Tests
{
    public  class MinStack_Tests
    {
        [Fact]
        public void RetrievingMin()
        {
            //arrange
            MinStack minStack = new MinStack();
            StackExample stack = new StackExample();
            //act
            stack.Push(5);
            stack.Push(7);
            stack.Push(3);
            //assert
            Assert.Equal(1, minStack.GetMin(stack));   

        }
        [Fact]
        public void PopThenRetrievMin() 
        {
            //arrange
            MinStack minStack = new MinStack();
            StackExample stack = new StackExample();
            //act
            stack.Push(5);
            stack.Push(3);
            stack.Push(2);
            stack.Pop();
            //assert
            Assert.Equal(3, minStack.GetMin(stack));
        }
        [Fact]
        public void PushThenRetrievMin()
        {
            //arrange
            MinStack minStack = new MinStack();
            StackExample stack = new StackExample();
            //act
            stack.Push(5);
            stack.Push(7);
            stack.Push(3);
            stack.Push(2);
            //assert
            Assert.Equal(2, minStack.GetMin(stack));

        }
    }
}
