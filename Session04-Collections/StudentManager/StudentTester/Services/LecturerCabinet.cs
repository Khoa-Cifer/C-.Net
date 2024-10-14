using StudentTester.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTester.Services
{
    public class LecturerCabinet
    {
        private Lecturer[] _arr;
        private int _count = 0;

        public LecturerCabinet(int size)
        {
            if (size < 1)
            {
                size = 69;
            }
            _arr = new Lecturer[size];
        }

        public void AddLecturer(Lecturer lecturer) => _arr[_count++] = lecturer; //expression body
        public void AddLecturer(string id, string name, int yob, double salary)
        {
            _arr[_count] = new Lecturer() { Id = id, Name = name, Yob = yob, Salary = salary };
            _count++;
        }

        public void PrintLecturerList()
        {
            Console.WriteLine($"There is/are {_count} lecturer(s) in the list");
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }

        public void RemoveLecturer(string id)
        {
            int? pos = SearchLecturerById(id);

            if (pos.HasValue)
            {
                for (int i = (int)pos; i < _count - 1; i++)
                {
                    _arr[i] = _arr[i + 1];
                }
                _arr[_count] = null;
                _count--;
                Console.WriteLine("Delete successfully");
            }
        }

        public void UpdateLecturer(string id, string? newName, int? newYob, double? newSalary)
        {

            int? pos = SearchLecturerById(id);
            if (pos.HasValue)
            {
                _arr[(int)pos].Name = newName;
                _arr[(int)pos].Yob = (int)newYob;
                _arr[(int)pos].Salary = (double)newSalary;
                Console.WriteLine("Update successfully");
            }
            else
            {
                Console.WriteLine("Student not found");
            }
        }

        public int? SearchLecturerById(string id)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_arr[i].Id.ToLower() == id.ToLower())
                {
                    return i; //Tìm thấy tại vị trí thứ i
                }
            }
            return null;
        }
    }
}
