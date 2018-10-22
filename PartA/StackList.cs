/*
 * Andrew Dorre
 * Module 06 Project
 * Part A
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartA
{
    //Also taken from the book, but this implementation is also pretty simple too
    //It just utilizes existing methods within the base class to create two new methods
    public class StackList : LinkedList
    {
        public StackList() : base("stack") { }

        public void Push(object dataValue)
        {
            InsertAtFront(dataValue);
        }

        public object Pop()
        {
            return RemoveFromFront();
        }
    }
}
