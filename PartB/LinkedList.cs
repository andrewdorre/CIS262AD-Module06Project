using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartB
{
    

    
    // Using book to create LinkedList class and ListNode class
    public class ListNode
    {
        public object Data { get; private set; }

        public ListNode Next { get; set; }

        public ListNode(object dataValue) : this(dataValue, null) { }

        public ListNode(object dataValue, ListNode nextNode)
        {
            Data = dataValue;
            Next = nextNode;
        }
    }

    class LinkedList
    {
        //***Private fields***
        private ListNode firstNode;
        private ListNode lastNode;
        private string name;
        private int count;
        private ListNode compare;

        //***Constructors***
        public LinkedList(string listName)
        {
            name = listName;
            firstNode = lastNode = null;
        }

        public LinkedList() : this("list") { }

        //***Methods***
        public void InsertAtFront(object insertItem)
        {
            if (IsEmpty())
            {
                firstNode = lastNode = new ListNode(insertItem);
            }
            else
            {
                firstNode = new ListNode(insertItem, firstNode);
            }
            //Added to track the index length.
            count++;
        }

        public void InsertAtBack(object insertItem)
        {
            if (IsEmpty())
            {
                firstNode = lastNode = new ListNode(insertItem);
            }
            else
            {
                lastNode = lastNode.Next = new ListNode(insertItem);
            }
            //Added to track the index length
            count++;
        }

        public object RemoveFromFront()
        {
            if (IsEmpty())
            {
                throw new EmptyListException(name);
            }
            object removeItem = firstNode.Data;

            if (firstNode == lastNode)
            {
                firstNode = lastNode = null;
            }
            else
            {
                firstNode = firstNode.Next;
            }
            //Added to track the index length.
            count--;
            return removeItem;

        }
        

        public object RemoveFromBack()
        {
            if (IsEmpty())
            {
                throw new EmptyListException(name);
            }

            object removeItem = lastNode.Data;

            if (firstNode == lastNode)
            {
                firstNode = lastNode = null;
            }
            else
            {
                ListNode current = firstNode;

                while (current.Next != lastNode)
                {
                    current = current.Next;
                }

                lastNode = current;
                current.Next = null;
            }
            return removeItem;
        }

        //***Public properties***
        public bool IsEmpty()
        {
            return firstNode == null;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine($"Empty {name}");
            }
            else
            {
                Console.Write($"The {name} is: ");

                ListNode current = firstNode;

                while (current != null)
                {
                    Console.Write($"{current.Data} ");
                    current = current.Next;
                }
            }
        }
        public void Compare(int first, int second)
        {
            ListNode current = firstNode;

            while (current != null)
            {                
                if (first < second)
                {
                    compare = new ListNode(first, current);
                }
                current = current.Next;
                
                
            }
            //return compare;
        }

        //Count public property added to track indexes
        public int Count
        {
            get { return count; }
        }

        //this allows me to select specific indexes
        public object this[int index]
        {
            get { return Get(index); }
        }
        //Including this as well, from BetterCoder videos
        //https://www.youtube.com/watch?v=cEsicmlaWDk&list=PL3iOx6lykrwrlVijTcZI3l8Hz_9W3Pb9F

        public object Get(int index)
        {
            if (index >= count)
                index = count - 1;

            ListNode current = firstNode;


            for (int i = 0; i < index; i++)
                current = current.Next;

            return current.Data;

        }


        //***Exception Class***
        public class EmptyListException : Exception
        {
            public EmptyListException() : base("The list is empty") { }

            public EmptyListException(string name) : base($"The {name} is empty") { }

            public EmptyListException(string exception, Exception inner) : base(exception, inner) { }
        }
        
    }
    
}
