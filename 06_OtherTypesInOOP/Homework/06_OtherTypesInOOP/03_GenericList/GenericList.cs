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

        public void Add(T element)
        {
            if (this.Count == elements.Length)
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

        public void Clear()
        {
            this.Capacity = DEFAULT_CAPACITY;
            elements = new T[this.Capacity];
            this.count = 0;
        }

        public int Find(T value)
        {
            if (value == null)
            {
                return -1;
            }

            for (int i = 0; i < elements.Length; i++)
            {
                if (value.Equals(elements[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public bool Contains(T value)
        {
            return Find(value) != -1;
        }

        public T Access(int index)
        {
            AssertIndexIsInListRange(index);
            return this.elements[index];
        }

        public void Insert(T element, int index)
        {
            if (index >= this.Count)
            {
                Add(element);
            } else
            {
                if (this.Count == elements.Length)
                {
                    DoubleCapacity();
                }

                T currentValue = elements[index];
                elements[index] = element;

                if (currentValue != null)
                {
                    index++;
                    Insert(currentValue, index);
                }
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
            if (index >= this.Count || index < 0)
            {
                throw new IndexOutOfRangeException(String.Format(
                    "The index {0} is out of range for this list.", index));
            }
        }

        public override string ToString()
        {
            string result = String.Join(", ", elements);

            return result;
        }
    }
}
