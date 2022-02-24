using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Item
    {
        public int Value;
        public Item Next;
        public Item(int num)
        {
            Value = num;
            Next = null;
        }
        public void Print()
        {
            Console.WriteLine(Value);
            if (Next != null)
            {
                Next.Print();
            }
        }
        
}
}
