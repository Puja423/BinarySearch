using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree();
        }
        public static void BinarySearchTree()
        {
            Console.WriteLine("Welcome to BInary Search Tree Demo!");

            var bst = new BinarySearchTreeAdd<int>();
            bst.Add(56);
            bst.Add(30);
            bst.Add(70);
            bst.Display(bst.value);

        }
    }
}
