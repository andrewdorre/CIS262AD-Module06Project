using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartA
{

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
