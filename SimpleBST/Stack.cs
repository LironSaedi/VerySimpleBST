using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleBST
{
    class Stack<T>
    {
        
        public int count { get; private set; }
        public T[] array;

        public Stack(int capacity = 10)
        {
            array = new T[10];
            count = 0;
        }
        public void Push(T item)
        {
            if (array.Length == count)
            {
                Resize(array.Length * 2);
            }

            array[count] = item;
            count++;
        }
        public T Pop()
        {

            count--;
            return array[count];

        }
        public T Peek()
        {
            return array[count];
        }
        private void Resize(int size)
        {
            T[] holder = new T[size];
            for (int i = 0; i < array.Length; i++)
            {
                holder[i] = array[i];
            }
            array = holder;
        }


        public void Clear()
        {
            T[] holder = new T[10];
            array = holder;
        }
        public bool IsEmpty()
        {
            if (array.Length == 0)
            {
                return true;
            }
            return false;
        }
        
    }
}
