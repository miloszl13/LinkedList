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
            try
            {
                return _linkedlist.showLastItem();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
        public void Print()
        {
            _linkedlist.showAllItem();
        }
      
    }
}
