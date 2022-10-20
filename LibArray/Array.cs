using System;
using System.Security.Cryptography.X509Certificates;

namespace LibArray
{
    public class Array<T>
    {
        private T[] _items;
        private int _capacity;

        public Array(int capacity)
        {
            _items = new T[capacity];
            Capacity = capacity;
        }

        public int Capacity
        {
            get
            {
                return _capacity;
            }
            private set
            {
                _capacity = value;
            }
        }

        public int cap()
        {
            return _capacity;
        }
    }
}
