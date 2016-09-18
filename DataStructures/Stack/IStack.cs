using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Stack
{
    interface IStack<T>
    {
        void push(T item);
        T pop();
    }
}
