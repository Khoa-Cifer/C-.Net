using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTesterV4.Entities
{
    public class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;

        //getId() setId()
        //SetId() GetId()
        //Id được gọi là property của 1 class/object
        //_id/_field được gọi là backing field chống lưng cho property ra bên ngoài flex
        //Đằng sau 1 property là 1 _backing field
        public string Id //="SE1" => Tự hiểu, hàm set được gọi, set value SE1 vào biến _id
                         //chấm (.id) tự gọi getter
        {
            get 
            { 
                return _id; 
            } 
            set 
            { 
                _id = value; 
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        //Dùng expression body
        public int Yob 
        { 
            get => _yob;
            set => _yob = value;
        }

        public double Gpa { get => _gpa;  set => _gpa = value; }

        public override string? ToString() => $"{_id} {Name} {Yob} {_gpa}";
    }
}
