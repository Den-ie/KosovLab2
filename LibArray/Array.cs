using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace LibArray
{
    public class Array<T>
    {
        private T[] _items;
        private int _capacity;

        private readonly int _defaultcapacity = 8;

        public Array(int capacity)
        {
            _items = new T[capacity];
            Capacity = capacity;
        }

        public int Lenght { get; private set; }

        public T this[int index]
        {
            get { return _items[index]; }
            set { _items[index] = value; }
        }

        public int Capacity
        {
            get => _capacity;
            private set
            {
                if(value==_capacity)
                {
                    return;
                }
                
                _capacity = value;
                Array.Resize(ref _items, _capacity);
            }
        }

        private int EnsureCapacity(int itemsLenght = 0)
        {
            int tempCapacity = Capacity;
            while(itemsLenght + Lenght >= tempCapacity)
            {
                tempCapacity *= 2;
            }

            return tempCapacity;
        }

        public void Add(T item)
        {
            Capacity = EnsureCapacity();
            _items[Lenght++] = item;
        }

        public void Clear()
        {
            Capacity = _defaultcapacity;
            Lenght = 0;
            _items = new T[Capacity];
        }

        public T[] ToArray()
        {
            return _items.Take(Lenght).ToArray();
        }
    }
}
