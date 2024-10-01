using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTesterV3.Entities
{
    public class Student
    {
        private string _id;
        private string _name;
        private string _email;
        private string _password;

        //constructor default chủ động explicit
        public Student()
        {
            
        }

        public Student(string id, string name, string email, string password)
        {
            _id = id;
            _name = name;
            _email = email;
            _password = password;
        }

        public override string? ToString() => $"{_id} {_name} {_email} {_password}";

        //Gõ ctrl . -> generate constructor
        //GET/SET làm nốt


    }
}
