using StackAndQueue;
using StackAndQueue.ReverseStackUsingQueue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue_Tests
{
    public class ReverseStackUsingQueue_Tests
    {
        [Fact]
        public void ReversingStackWithMultipleElements()
        {
            //arrange
            StackWithReverse reverse = new StackWithReverse();
            StackExample stack=new StackExample();  
            //act
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            reverse.ReverseStack(stack);
            //assert
            Assert.Equal(1,stack.Pop());
        }

        [Fact]
        public void ReversingStackWithSingleElements()
        {
            //arrange
            StackWithReverse reverse = new StackWithReverse();
            StackExample stack = new StackExample();
            //act
            stack.Push(1);
            reverse.ReverseStack(stack);
            //assert
            Assert.Equal(1, stack.Pop());
        }

        [Fact]
        public void IsEmptyStack()
        {
            //arrange
            StackWithReverse reverse = new StackWithReverse();
            StackExample stack = new StackExample();
            //act
            reverse.ReverseStack(stack);
            //assert
            Assert.True(stack.IsEmpty());
        }
    }
}
