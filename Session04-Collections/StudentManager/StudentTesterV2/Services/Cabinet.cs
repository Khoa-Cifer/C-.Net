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
    }
}

//Bài tập về nhà, bài 3, nốt class này