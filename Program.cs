using System;

namespace BinarySearchTree

{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> bt = new BinaryTree<int>();
            bt.Push(56);
            bt.Push(30);
            bt.Push(76);
            Console.WriteLine(bt.Size());
            Console.WriteLine(bt.Search(80));
        }
    }
}
