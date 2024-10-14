using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTesterV5.Entities
{
    public class Student
    {
        //_backing field và property
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;

        //Cú pháp giúp gợi nhớ cách gõ property
        //propfull tab tab
        //cách ta xài property kèm _backing field gọi là full property - property đầy đủ mặt tiền và nhà biến
        public string Id { 
            get => _id; 
            set => _id = value;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Yob
        {
            get => _yob;
            set => _yob = value;
        }

        public double Gpa
        {
            get => _gpa;
            set => _gpa = value;
        }

    }
}
