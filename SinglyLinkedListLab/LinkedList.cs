using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedListLab
{
    public class LinkedList
    {
        public Node Head { get; set; }
        public int Count { get; private set; }

        public LinkedList() { }

        public void AddFirst(string value)
        {
            Node newNode = new Node(value);

            if (Head != null)
            {
                newNode.Next = Head;
                Head = newNode;
            }
            else { this.Head = newNode; }


            this.Count++;
        }

        public void AddLast(string value)
        {
            Node newNode = new Node(value);

            if (Head != null)
            {
                Node currentNode = Head;
                while (currentNode.Next != null) 
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = newNode;
            }
            else { this.Head = newNode; }


            this.Count++;
        }

        public void RemoveFirst()
        {
            if (Head != null)
            {
                Node first = Head;

                Head = first.Next;

                this.Count--;
            }
        }

        public void RemoveLast()
        {
            if (Head != null)
            {                
                if (Count == 1) Head = null;
                else
                {
                    Node currentNode = Head;

                    for (int i = 0; i < Count-2; i++)
                    {
                        currentNode = currentNode.Next;
                    }
                    currentNode.Next = null;
                }
                
                this.Count--;
            }
        }

        public string GetValue(int index)
        {
            if ( index >=0 && index < Count)
            {
                if (index == 0) return Head.Value;

                Node currentNode = Head;

                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.Next;
                }
                return currentNode.Value;
            }
            return "Out of index";
        }
    }
}
