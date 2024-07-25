using StackAndQueue;

namespace StackAndQueue_Tests
{
    public class UnitTest1
    {
        //Stack Tests
        [Fact]
        public void PushingInStack()
        {
            //arrange
            StackExample stack=new StackExample();
            //act
            stack.Push(1);
            //assert
            Assert.Equal(1, stack.Peek());
        }

        [Fact]
        public void PoppingInStack()
        {
            //arrange
            StackExample stack = new StackExample();
            //act
            stack.Push(1);
            stack.Push(2);
            stack.Pop();
            //assert
            Assert.Equal(1, stack.Peek());
        }

        [Fact]
        public void StackIsEmpty()
        {
            //arrange
            StackExample stack = new StackExample();
            //act
            bool x = stack.IsEmpty();
            //assert
            Assert.True(x);
        }

        //Queue Tests
        [Fact]
        public void EnqueuingInQueue()
        {
            //arrange
            QueueExample queue = new QueueExample();
            //act
            queue.Enqueue(1);
            //assert
            Assert.Equal(1, queue.Peek());
        }

        [Fact]
        public void DequeuingInQueue()
        {
            //arrange
            QueueExample queue = new QueueExample();
            //act
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Dequeue();
            //assert
            Assert.Equal(2, queue.Peek());
        }

        [Fact]
        public void QueueIsEmpty()
        {
            //arrange
            QueueExample queue = new QueueExample();
            //act
            bool x = queue.IsEmpty();
            //assert
            Assert.True(x);
        }
    }
}