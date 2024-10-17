using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTesterV2.Services
{
    //Xài: Cabinet<Student> tuSE = new Cabinet<Student>();
    public class Cabinet<T>
    {
        private T[] _arr;
        private int _count = 0;

        public Cabinet(int size)
        {
            _arr = new T[size];
        }

        public void Add(T item)
        {
            _arr[_count++] = item;
        }

        public void PrintList()
        {
            Console.WriteLine($"There is/are {_count} item(s) in the list");
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }

        public void Remove(T item)
        {
            int? pos = SearchByItem(item);

            if (pos.HasValue)
            {
                for (int i = (int)pos; i < _count - 1; i++)
                {
                    _arr[i] = _arr[i + 1];
                }
                _arr[_count] = default(T);
                _count--;
                Console.WriteLine("Delete successfully");
            }
        }

        public int? SearchByItem(T item)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_arr[i].Equals(item))
                {
                    return i; //Tìm thấy tại vị trí thứ i
                }
            }
            //Đi hết for mà không thoát được, return null
            return null;
        }
    }
}

//Bài tập về nhà, bài 3, nốt class này