using System;
using System.Collections;

namespace LitwareLib
{
    public class MyStack<T>:ICloneable
    {
        internal int _top;
        internal int _size;
        internal T[] _stack;

        public MyStack(int size)
        {
            this._size = size;
            this._top = 0;
            this._stack = new T[size];
        }
        public MyStack(MyStack<T> stack)
        {
            this._top= stack._top;
            this._stack = (T[])stack._stack.Clone();
            this._size = stack._size;
        }
      
        public void push(T element)
        {
            if(_top==_size)
            {
                throw new StackException("Stack Overflow!");
            }
            _stack[_top]=element;
            _top++;
            Console.WriteLine("Element Added..");
        }
   
        public void pop()
        {
            if(_top == 0)
            {
                throw new StackException("Stack Underflow!");
            }
            _top--;
            Console.WriteLine("Element Deleted..");
        }
        public object Clone()
        {
            return new MyStack<T>(this);
        }
        public void PrintStack()
        {
            int temp = _top-1;
            while(temp>=0)
            {
                Console.Write(_stack[temp]+" ");
                temp--;
            }
            Console.WriteLine();
        }
    }
  
}


