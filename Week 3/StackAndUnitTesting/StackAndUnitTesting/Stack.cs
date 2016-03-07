using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndUnitTesting
{
    public class Stack
    {
        //Linked list pointers
        StringNode head;
        StringNode tail;

        public Stack()
        {
            head = null;
            tail = null;
        }

        //Adds a string to the stack
        public void Push(String stringToAdd)
        {
            //new string node to add the string node info
            StringNode stringNodeToAdd = new StringNode(stringToAdd);

            //find where to add new node to
            if (isEmpty())
            {
                head = stringNodeToAdd;
                tail = stringNodeToAdd;
            }
            else
            {
                tail.Next = stringNodeToAdd;
                tail = stringNodeToAdd;
            }
        }

        //returns the most recently added string and removes it from the stack
        public String Pop()
        {
            String popString = Peek();

            //if it only stringnode
            if (head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {
                StringNode nodeWalker = head;

                while (nodeWalker.Next != tail)
                    nodeWalker = nodeWalker.Next;

                //if next stringnode is tail
                if (nodeWalker.Next == tail)
                {
                    tail = nodeWalker;
                    nodeWalker.Next = null;
                }
            }

            return popString;
        }

        //returns the most recently added string but does not remove it from the stack
        public String Peek()
        {
            StringNode peekNode = tail;

            if(isEmpty() == true)
            {
                throw new Exception("Nothing to Peek at. Stack is empty");
            }
            else
            {
                return peekNode.Info;
            }
        }

        //returns the number of strings currently held in the stack
        public int Count()
        {
            int count = 0;
            StringNode nodeWalker = head;

            while (nodeWalker != null)
            {
                count++;
                nodeWalker = nodeWalker.Next;
            }
            return count;
        }

        //returns true if the stack contains zero elements and false otherwise
        public bool isEmpty()
        {
            if(Count()==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
