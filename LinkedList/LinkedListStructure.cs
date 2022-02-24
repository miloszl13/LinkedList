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
        }
        public int showLastItem()
        {
            if (first != null)
                return first.Value;
            else
                throw new Exception("You cant peek the item because List is empty");
        }
        public void showAllItem()
        {
            if(first!=null)
            first.Print();
            else
            {
                Console.WriteLine("You cant print the list because List is empty");
            }
        }


    }
}
