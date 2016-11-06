using System;
using System.Collections.Generic;

namespace ProofOfConcept.LinkedLists
{
    public class LinkedList<T>
    {
        private Node head;

        public T this[int index] { get { return this.getItem(index); } set { this.setItem(index, value); } }

        public int Count { get; set; }

        public LinkedList()
        {
            head = null;
        }

        public LinkedList(IEnumerable<T> collection) : this()
        {
            foreach (T t in collection) this.AppendAtEnd(t);
        }

        public void AppendAtStart(T t)
        {
            var current = head;
            var n = new Node(t);
            n.Next = current;
            head = new Node(t);
            head = n;
            Count++;
        }

        public void AppendAtEnd(T t)
        {
            if (head != null)
            {
                var tmp = head;
                while (tmp.Next != null)
                {
                    tmp = tmp.Next;
                }
                tmp.Next = new Node(t);
            }
            else head = new Node(t);
            Count++;
        }

        public void AppendAt(int index, T t)
        {
            if (index > 0 && index < Count)
            {
                var n = new Node(t);
                var before = head;
                for (var i = 1; i < index; i++) before = before.Next;
                var after = before.Next;
                n.Next = after;
                before.Next = n;
                Count++;
            }
            else if (index == 0) AppendAtStart(t);
            else if (index == Count) AppendAtEnd(t);
            else throw new IndexOutOfRangeException();
        }

        public void AppendRange(IEnumerable<T> collection)
        {
            foreach (T t in collection) this.AppendAtEnd(t);
        }

        public void RemoveAtStart()
        {
            var after = head.Next;
            head = after;
            Count--;
        }

        public void RemoveAtEnd()
        {
            if (head != null)
            {
                var tmp = head;
                if (tmp.Next != null)
                {
                    while (tmp.Next.Next != null)
                    {
                        tmp = tmp.Next;
                    }
                    tmp.Next = null;
                }
                else head = null;
                Count--;
            }
        }

        public void RemoveAt(int index)
        {
            if (index > 0 && index < Count - 1)
            {
                var before = head;
                for (var i = 1; i < index; i++) before = before.Next;
                var after = before.Next;
                before.Next = after.Next;
                Count--;
            }
            else if (index == 0) RemoveAtStart();
            else if (index == Count - 1) RemoveAtEnd();
            else throw new IndexOutOfRangeException();
        }

        public void Remove(T t)
        {
            var i = 0;
            var current = head;
            while (current != null && !(t.Equals(current.Data)))
            {
                i++;
                current = current.Next;
            }
            if (Count > i) this.RemoveAt(i);
        }
        public void Clear()
        {
            for (int i = Count; i > 0; i--) this.RemoveAtEnd();
        }

        public bool Contains(T t)
        {
            if (head != null)
            {
                var tmp = head;
                while (tmp.Next != null)
                {
                    if (t.Equals(tmp.Data)) return true;
                }
            }
            return false;
        }
        public IEnumerator<T> GetEnumerator()
        {
            var current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        private T getItem(int index)
        {
            if (index >= 0 && index <= Count)
            {
                var tmp = head;
                for (var i = 0; i < index; i++) tmp = tmp.Next;
                return tmp.Data;
            }
            else throw new IndexOutOfRangeException();
        }

        private void setItem(int index, T t)
        {
            if (index >= 0 && index <= Count)
            {
                var tmp = head;
                for (var i = 0; i < index; i++) tmp = tmp.Next;
                tmp.Data = t;
            }
            else throw new IndexOutOfRangeException();
        }
        private class Node
        {
            private Node next;
            private T data;

            public Node Next { get { return next; } set { next = value; } }
            public T Data { get { return data; } set { data = value; } }

            public Node(T t)
            {
                next = null;
                data = t;
            }
        }
    }
}
