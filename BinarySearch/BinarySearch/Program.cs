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
               var numbers = new int[5] { 4,5,78,34,53 };
            foreach(var num in numbers)
            {
                bst.Add(num);
            }
               bst.Display(bst.value);
                 bst.Search(5);
                Console.WriteLine(bst.Size());

        }
    }
}
