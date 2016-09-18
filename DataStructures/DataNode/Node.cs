using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.DataNode
{
    public class Node<T> : IEquatable<T>, IComparable<T>
    {

        T item;

        Node<T> next;
        Node<T> previous;
        
        public T Data
        {
            get
            {
                return item;
            }

            set
            {
                item = value;
            }

        }

        public Node<T> Previous
        {
            get
            {
                return previous;
            }

            set
            {
                previous = value;
            }
        }

        public Node<T> Next
        {
            get
            {
                return next;
            }

            set
            {
                next = value;
            }
        }

        int IComparable<T>.CompareTo(T other)
        {
            throw new NotImplementedException();
        }

        bool IEquatable<T>.Equals(T other)
        {
            throw new NotImplementedException();
        }
    }
}
