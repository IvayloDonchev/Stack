using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class MyStack<T>
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
    }
}
