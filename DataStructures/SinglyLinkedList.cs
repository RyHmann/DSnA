using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class SinglyLinkedList
    {
        public SNode? Head { get; set; } = null;

        public SinglyLinkedList()
        {

        }

        public SinglyLinkedList(SNode newNode)
        {
            Head = newNode; 
        }

        public void AddNode(int value)
        {
            if (Head == null)
            {
                Head = new SNode(value);
            }

            else if (Head.Next is null)
            {
                Head.Next = new SNode(value);
            }
            else
            {
                var tail = Head.Next;

                while (tail.Next != null)
                {
                    tail = tail.Next;
                }
                tail.Next = new SNode(value);
            }
        }

        public int FindValue(int value)
        {
            int index = -1;
            int counter = 0;

            var currentNode = Head;
            if (currentNode.Next is null)
            {
                if (currentNode.Value == value)
                {
                    index = counter;
                }
            }
            else
            {
                while (currentNode.Value != value)
                {
                    counter++;
                    currentNode = currentNode.Next;
                    //check value
                    if (currentNode.Value == value)
                    {
                        index = counter;
                    }
                }
            }

            return index;
        }

        public void DeleteNode(int index)
        {
            int counter = 0;

            // Iterate through each .Next
            // Increment counter
            // Stop when counter == index
            var previousNode = Head;
            if (Head.Next is not null)
            {
                var currentNode = previousNode.Next;
                counter++;

                while (currentNode.Next is not null)
                {
                    previousNode = currentNode;
                    currentNode = currentNode.Next;
                    counter++;
                    if (counter == index)
                    {
                        previousNode.Next = currentNode.Next;
                    }
                }
            }
        }

        public void InsertNode(int index, int value)
        {
            throw new NotImplementedException();
        }
    }

    public class SNode
    {
        public int Value { get; set; }
        public SNode? Next { get; set; }

        public SNode(int value)
        {
            Value = value;
            Next = null;
        }
    }
}
