using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedListStructure<T>:IEnumerable<T>
    {
        private readonly List<T> _list=new List<T>();
        public bool IsEmpty => Count == 0;
        public int Count => _list.Count;
        public void Add(T value)
        {
            _list.Add(value);
        }
        public T Peek()
        {
            if (IsEmpty)
                throw new InvalidOperationException();
            return _list.Last();
        }
        public void Print()
        {
            for(int i=_list.Count;i>0;i--)
                Console.WriteLine(i);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
