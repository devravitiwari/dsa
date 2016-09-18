using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.DataNode;

namespace DataStructures.List
{
    public class List<T> : IList<T>
    {
        Node<T> head;
        Node<T> tail;
        
        public Node<T> Current
        {
            get
            {
                return tail;
            }
        }

        public void Add(T item)
        {
            if(head == null)
            {
                head = new Node<T>();
                head.Data = item;
                tail = head;

            }
            else
            {
                var node = new Node<T>();
                node.Data = item;
                node.Previous = tail;
                tail.Next = node;
                tail = node;
            }
        }

        public Node<T> Remove(T item)
        {
            // need to find the item
            // if not, return false
            // else adjust next and previous and return true

            // not we need an equatable notion for nodes to compare

            var node = Find(item);
            if(node == null)
            {
                return null;
            }

            // Check if node is head or is tail and set previous and next pointers accordingly

            if(node == head)
            {
                head = node.Next;
                node.Next.Previous = null;
            }
            else if (node == tail)
            {
                tail = node.Previous;
                node.Previous.Next = null;
            }
            else
            {
                node.Previous.Next = node.Next;
                node.Next.Previous = node.Previous;
            }
            return node;
        }

        public Node<T> Find(T item)
        {
            var current = head;
            bool found = false;
            while(current != null)
            {
                if(current.Data.Equals(item))
                {
                    found = true;
                    break;
                }
                current = current.Next;
            }

            return found ? current : null;
        }


        public void Print()
        {
            var current = head;
            Console.Write("[ ");
            while (current != null)
            {
                Console.Write(" {0} , ", current.Data);
                current = current.Next;

            }
            Console.WriteLine(" ]");
        }

        void IList<T>.Add(T item)
        {
            Add(item);
        }

        bool IList<T>.Remove(T item)
        {
            return Remove(item);
        }
    }
}
