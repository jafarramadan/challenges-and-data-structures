using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProject
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
        public Node()
        {
        }
    }

    public class LinkedList
    {
        public Node Head { get; private set; }

        public LinkedList()
        {
            Head = null;
        }

        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }
        

        public bool Includes(int data)
        {
            Node current = Head;
            while (current != null)
            {
                if (current.Data == data)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void Remove(int data)
        {
            if (Head == null)
            {
                throw new InvalidOperationException("The list is empty.");
            }

            if (Head.Data == data)
            {
                Head = Head.Next;
                return;
            }

            Node current = Head;
            while (current.Next != null && current.Next.Data != data)
            {
                current = current.Next;
            }

            if (current.Next == null)
            {
                throw new InvalidOperationException("Data not found in the list.");
            }

            current.Next = current.Next.Next;
        }

        public void PrintList()
        {
            Node current = Head;
            Console.Write("Head->");
            while (current != null)
            {
                Console.Write(current.Data + "->");
                current = current.Next;
            }
            Console.WriteLine("Null");
        }


        //remove duplicate part
        public void RemoveDuplicate()
        {
            Node current = Head;
            while (current != null)
            {
                Node runner = current;
                while (runner.Next != null)
                {
                    if (runner.Next.Data == current.Data)
                    {
                        runner.Next = runner.Next.Next;
                    }
                    else
                    {
                        runner = runner.Next;
                    }
                }
                current = current.Next;
            }
        }

        //merge sorted list 

        public LinkedList MergeSortedLists(LinkedList list1 , LinkedList list2)
        {
            LinkedList mergedLinkedList= new LinkedList();
            if (list1.Head == null) return list2;
            if (list2.Head == null) return list1;
            Node temp = new Node();
            Node tail = temp; 
            Node current1 = list1.Head;
            Node current2 = list2.Head;
            
            while (current1 != null && current2 !=null)
            {
                if (current1.Data <= current2.Data)
                {
                    tail.Next = current1;
                    current1 = current1.Next;
                }
                else
                {
                    tail.Next= current2;
                    current2 = current2.Next;
                }
                tail=tail.Next;
            }
            tail.Next = (current1 != null) ? current1 : current2;
            mergedLinkedList.Head = temp.Next;
            return mergedLinkedList;
        }

        public LinkedList RotateLeft(LinkedList list , int k)
        {
            if (k == 0 || list.Head==null)
            {
                return list;
            }
            Node current = Head; //1
            while (k != 0)
            {
                list.Add(current.Data);//1-2-3-4-5-1
                list.Remove(current.Data);//2-3-4-5-1
                current = current.Next;
                k--;
            }
            return list;
        }

        
    }
}