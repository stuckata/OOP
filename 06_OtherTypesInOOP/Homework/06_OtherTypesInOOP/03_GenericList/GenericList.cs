using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_GenericList
{
    public class GenericList<T>
    {
        const int DEFAULT_CAPACITY = 16;

        private T[] elements;
        private int count = 0;
        private int capacity;

        public GenericList(int capacity = DEFAULT_CAPACITY)
        {
            elements = new T[capacity];
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            set
            {
                this.capacity = value;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Invalid index: {0}.", index));
                }
                T result = elements[index];
                return result;
            }
        }

        private void DoubleCapacity()
        {
            T[] oldElements = new T[this.Capacity];
            Array.Copy(elements, oldElements, this.Capacity);
            int oldCapacity = this.Capacity;
            this.Capacity *= 2;
            elements = new T[this.Capacity];
            Array.Copy(oldElements, elements, oldCapacity);
        }

        private void AssertIndexIsInListRange(int index)
        {
            if (index >= elements.Length)
            {
                throw new IndexOutOfRangeException(String.Format(
                    "The index {0} is out of range for this list.", index));
            }
        }

        public void Add(T element)
        {
            if (count == elements.Length)
            {
                DoubleCapacity();
            }
            this.elements[count] = element;
            count++;
        }

        public void Remove(int index)
        {
            AssertIndexIsInListRange(index);

            for (int i = 0; i < this.elements.Length - 1; i++)
            {
                if (i >= index)
                {
                    this.elements[i] = this.elements[i + 1];
                }
            }
            count--;
        }

        public T Access(int index)
        {
            AssertIndexIsInListRange(index);


        }
    }
}
