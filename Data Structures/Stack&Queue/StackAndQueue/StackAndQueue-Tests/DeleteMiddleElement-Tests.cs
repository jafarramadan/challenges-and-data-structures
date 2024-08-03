using StackAndQueue;
using StackAndQueue.DeleteMiddleElement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue_Tests
{
    public class DeleteMiddleElement_Tests
    {
        [Fact]
        public void DeleteOdd()
        {
            //arrange
            StackExample stack = new StackExample();
            StackWithDeleteMiddle stackWithDeleteMiddle = new StackWithDeleteMiddle();
            //act
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stackWithDeleteMiddle.DeleteMiddle(stack);
            //assert
            Assert.Equal(4, stack.Countt(stack));


        }

        [Fact]
        public void DeleteEven()
        {
            //arrange
            StackExample stack = new StackExample();
            StackWithDeleteMiddle stackWithDeleteMiddle = new StackWithDeleteMiddle();
            //act
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stackWithDeleteMiddle.DeleteMiddle(stack);
            //assert
            Assert.Equal(5, stack.Countt(stack));


        }
    }
}
