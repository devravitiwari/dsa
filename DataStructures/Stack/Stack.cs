using DataStructures.DataNode;
using DataStructures.List;

namespace DataStructures.Stack
{
    public class Stack<T> : IStack<T>
    {
        List<T> stack;
        Node<T> top;        

        public Stack()
        {
            stack = new List<T>();

        }

        public void push(T item)
        {
            stack.Add(item);
            top = stack.Current;
        }

        public T pop()
        {
            return stack.Remove(top.Data).Data;
        }

        T IStack<T>.pop()
        {
            return pop();
        }

        void IStack<T>.push(T item)
        {
            push(item);
        }
    }
}
