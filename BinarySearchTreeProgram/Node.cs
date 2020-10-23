using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTreeProgram
{
    class Node<T> where T : IComparable
    {
        public T NodeValue;
        public Node<T> LeftNode;
        public Node<T> RightNode;
        public Node(T NodeValue)
        {
            this.NodeValue = NodeValue;
        }


    }
}
