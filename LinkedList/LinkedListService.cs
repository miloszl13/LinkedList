using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedListService
    {
        LinkedListStructure _linkedlist=new LinkedListStructure();
        public void Add(int value)
        {
            _linkedlist.Add(value);
        }
        public int Peek()
        {
            if (_linkedlist.IsEmpty)
            {
                throw new InvalidOperationException();
            }
            return _linkedlist.showLastItem();
        }
        public void Print()
        {
            _linkedlist.showAllItem();
        }
      
    }
}
