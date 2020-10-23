using System;

namespace BinarySearchTreeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree Program");
            Console.WriteLine("Welcome To Binary Search Tree Program");
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
            binarySearchTree.InsertData(56);
            binarySearchTree.InsertData(30);
            binarySearchTree.InsertData(70);
            binarySearchTree.InsertData(22);
            binarySearchTree.InsertData(40);
            binarySearchTree.InsertData(11);
            binarySearchTree.InsertData(3);
            binarySearchTree.InsertData(16);
            binarySearchTree.InsertData(60);
            binarySearchTree.InsertData(95);
            binarySearchTree.InsertData(65);
            binarySearchTree.InsertData(63);
            binarySearchTree.InsertData(67);

            binarySearchTree.Display(binarySearchTree.GetRoot());
            Console.WriteLine("Count of elements :" + binarySearchTree.GetSize());
        }
    }
}
