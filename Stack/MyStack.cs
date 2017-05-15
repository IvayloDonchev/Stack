using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Stack
{
    public class MyStack<T> : IEnumerable<T>, ICloneable
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
            try
            {
                Node p = new Node(x);
                p.next = sp;
                sp = p;
            }
            catch(OutOfMemoryException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
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

        public List<T> ToList()
        {
            List<T> list = new List<T>();
            for (var el = sp; el != null; el = el.next)
                list.Add(el.key);
            return list;
        }

        public Stack<T> ToStack()
        {
            Stack<T> stack = new Stack<T>();
            for (var el = sp; el != null; el = el.next)
                stack.Push(el.key);
            return stack;
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

        public object Clone()
        {
            MyStack<T> copy = new MyStack<T>();
            foreach (var x in this)
                copy.Push(x);
            return (object) copy;
        }

        public T this[int index]    // indexer
        {
            get
            {
                var p = sp;
                for(int i=1; i<=index; i++)
                {
                    if (p == null)
                        throw new IndexOutOfRangeException("Incorrect index!");
                    p = p.next;
                }
                return p.key;
            }
        }
    }
}
