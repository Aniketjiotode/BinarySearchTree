using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree


{
    internal class BinaryTree<T> where T: IComparable
    {
        private Node head;
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
                    if (head.CompareTo(n)==1)
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
                if (p != null && p.CompareTo(n)==1)
                {
                    n.Next = p;
                    head = n;
                    return;
                }
                if (t.Next == null && n.CompareTo(t)==1)
                {
                    t.Next = n;
                    return;
                }
                if (p != null && p.CompareTo(n)==-1 && t.CompareTo(n)==1)
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
        public override string ToString()
        {
            if (head == null)
            {
                return null;
            }
            Node t = head;
            string s = "";
            while (t != null)
            {
                s = s + t.data + " ";
                t = t.Next;
            }
            return s;
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







