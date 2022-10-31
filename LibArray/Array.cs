using System;
using System.Data;
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

        public int Length { get; private set; }

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
                if (value == _capacity)
                {
                    return;
                }

                _capacity = value;
                Array.Resize(ref _items, _capacity);
            }
        }

        /// <summary>
        /// Расширение длинны массива
        /// </summary>
        /// <param name="itemsLenght"> Длина </param>
        /// <returns></returns>
        private int EnsureCapacity(int itemsLenght = 0)
        {
            int tempCapacity = Capacity;
            while (itemsLenght + Length >= tempCapacity)
            {
                tempCapacity *= 2;
            }

            return tempCapacity;
        }

        /// <summary>
        /// Вывод в таблицу
        /// </summary>
        /// <returns></returns>
        public DataTable ToDataTable()
        {
            var res = new DataTable();

            for (int i = 0; i < Length; i++)
            {
                res.Columns.Add("col" + (i + 1), typeof(T));
            }

            var row = res.NewRow();

            for (int i = 0; i < Length; i++)
            {
                row[i] = _items[i];
            }

            res.Rows.Add(row);
            return res;
        }

        /// <summary>
        /// Добавление массива в конец существующего
        /// </summary>
        /// <param name="items"> Массив для добавления </param>
        public void AddRange(T[] items)
        {
            Capacity = EnsureCapacity(items.Length);
            Array.Copy(items, 0, _items, Length, items.Length);
            Length += items.Length;
        }

        /// <summary>
        /// Удаление введенного элемента
        /// </summary>
        /// <param name="item"> Элемент для удаления </param>
        /// <returns></returns>
        public bool Remove(T item)
        {
            int x = Array.IndexOf(_items, item);

            if (x >= 0)
            {
                Array.Copy(_items, x+1, _items, x, Capacity - (x+1));
                Length--;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Добавление элемента
        /// </summary>
        /// <param name="item"> Добавляющийся элемент </param>
        public void Add(T item)
        {
            Capacity = EnsureCapacity();
            _items[Length++] = item;
        }

        /// <summary>
        /// Очищение
        /// </summary>
        public void Clear()
        {
            Capacity = _defaultcapacity;
            Length = 0;
            _items = new T[Capacity];
        }
    }
}
