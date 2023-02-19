using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace BinarySearchTree
{
    internal class BinaryTree<T> where T : IComparable
    {
        private Node head;
        public T[] arr;

        public class Node
        {
            public T data;
            public Node Next;
            public Node(T data)
            {
                this.data = data;
            }
            public int CompareTo(Node compare)
            {
                return this.data.CompareTo(compare.data);
            }
        }
        public void Push(T data)
        {

            Node n = new Node(data);
            if (head == null)
            {
                head = n;
                return;
            }
            Node t = head, p = null;
            while (t != null)
            {
                if (head.Next == null)
                {
                    if (head.CompareTo(n) == 1)
                    {
                        n.Next = head;
                        head = n;
                        return;
                    }
                    else
                    {
                        head.Next = n;
                        return;
                    }
                }
                if (p != null && p.CompareTo(n) == 1)
                {
                    n.Next = p;
                    head = n;
                    return;
                }
                if (t.Next == null && n.CompareTo(t) == 1)
                {
                    t.Next = n;
                    return;
                }
                if (p != null && p.CompareTo(n) == -1 && t.CompareTo(n) == 1)
                {
                    n.Next = p.Next;
                    p.Next = n;
                    return;
                }
                p = t;
                t = t.Next;
            }
            return;
        }
        public T[] datalist()
        {
            if (head == null)
            {
                return null;
            }
            Node t = head;
            arr= new T[Size()];
            
            for (int i=0; t != null; i++)
            {          
                arr[i] = t.data;
                t = t.Next;
            }
            return arr;
        }
        public bool Search(T data)
        {
            T[] arr = datalist();

            int l = 0, h = Size() - 1;
            while (l <= h)
            {
                int m = l + (h - l) / 2;

                int res = data.CompareTo(arr[m]);

                if (res == 0)
                    return true;

                if (res > 0)
                    l = m + 1;

                else
                    h = m - 1;
            }
            return false;
        }
         public int Size()
        {
            if (head == null)
                return 0;
            Node t = head; int count = 0;
            while (t != null)
            {
                count++;
                t = t.Next;
            }
            return count;
        }
    }
}







