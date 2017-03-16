using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class MyStack<T> : IEnumerable<T>
    {
        private class Node
        {
            public T key;
            public Node next;
            public Node(T x)
            {
                key = x;
                next = null;
            }
            public Node() : this(default(T)) { }
        }
        private Node sp;    // Stack Pointer
        public void Push(T x)
        {
            Node p = new Node(x);
            p.next = sp;
            sp = p;
        }
        public T Pop()
        {
            if(sp != null)
            {
                T x = sp.key;
                sp = sp.next;
                return x;
            }
            throw new InvalidOperationException("Stack empty...");
        }

        internal List<T> ToList()
        {
            List<T> list = new List<T>();
            for (var el = sp; el != null; el = el.next)
                list.Add(el.key);
            return list;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (var x = sp; x != null; x = x.next)
                yield return x.key;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (var x = sp; x != null; x = x.next)
                yield return x.key;
        }
    }
}
