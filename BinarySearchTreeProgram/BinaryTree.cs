using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTreeProgram
{
    class BinarySearchTree<T> where T : IComparable
    {
        Node<T> Root;
        Node<T> Current;
        
        public void InsertData(T data)
        {
            if (Root == null)
            {
                this.Root = new Node<T>(data);
                this.Current = Root;
                return;
            }
            if (this.Current.NodeValue.CompareTo(data) > 0)
            {
                if (this.Current.LeftNode == null)
                {
                    this.Current.LeftNode = new Node<T>(data);
                    this.Current = Root;

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
    }
  }
