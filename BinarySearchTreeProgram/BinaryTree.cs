using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTreeProgram
{
    class BinarySearchTree<T> where T : IComparable
    {
        Node<T> Root;
        Node<T> Current;
        int count = 0;
        bool result = false;
        public void InsertData(T data)
        {
            if (Root == null)
            {
                this.Root = new Node<T>(data);
                this.Current = Root;
                count++;
                return;
            }
            if (this.Current.NodeValue.CompareTo(data) > 0)
            {
                if (this.Current.LeftNode == null)
                {
                    this.Current.LeftNode = new Node<T>(data);
                    this.Current = Root;
                    count++;

                }
                else
                {
                    this.Current = this.Current.LeftNode;
                    InsertData(data);
                }
            }
            else
            {
                if (this.Current.RightNode == null)
                {
                    this.Current.RightNode = new Node<T>(data);
                    this.Current = Root;
                    count++;
                }
                else
                {
                    this.Current = this.Current.RightNode;
                    InsertData(data);
                }
            }

        }
        public Node<T> GetRoot()
        {
            return this.Root;
        }
        public void Display(Node<T> node)
        {
            if (node != null)
            {
                Display(node.LeftNode);
                Console.WriteLine(" " + node.NodeValue);
                Display(node.RightNode);
            }

        }
        public int GetSize()
        {
            return count;
        }

        public bool SearchTree(int data, Node<T> node)
        {
            
            if (node == null)
            {
                return false;
            }
            else
            {
                if (this.Current.NodeValue.Equals(data))
                {
                    result = true;
                }
                else if (this.Current.NodeValue.CompareTo(data) > 0)
                {
                    this.Current = this.Current.LeftNode;
                    SearchTree(data, Current);
                }
                else
                {
                    this.Current = this.Current.RightNode;
                    SearchTree(data, Current);
                }

                return result;
            }
        }

    }
}

