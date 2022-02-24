using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedListStructure
    {
        public Item first { get; set; }
        public Item next { get; set; }
        public bool IsEmpty => Count == 0;
        public int Count = 0;

        public void Add(int value)
        {
            AddNewItem(new Item(value));
        }

        private void AddNewItem(Item item)
        {
            Item newItem = first;
            first = item;
            first.Next = newItem;

            Count++;

            if (Count == 1)
            {
                next = first;
            }
        }
        public int showLastItem()
        {
            return first.Value;
        }
        public void showAllItem()
        {
            first.Print();
        }

    }
}
