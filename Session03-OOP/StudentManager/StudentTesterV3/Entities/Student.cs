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
        public string GetName() => _name;
        public string GetEmail() => _email;
        public string GetPassword() => _password;
        //Hàm get chẳng qua là lấy cái tên biến đưa cho ai đó dùng
        //Tên biến ứng với get value, vì biến là value

        public void SetName(string name) => _name = name;
        public void SetEmail(string email) => _email = email;
        public void SetPassword(string password) => _password = password;
        //Hàm set cần 1 value đưa vào
        //Hàm set chẳng qua là lấy tên biến gán = 1 value nào đó
        //Tên biến = 1 value, tức là set

        //Tên biến đã bao gồm get() set()
        //Vậy tan có thể đổi style code được không ?, đổi các hàm boilerplate (Get..., Set...)

        //Muốn làm được get(), set() tự nhiên như xài biến, thì phải đi qua còn đuòng xài biến, nhưng không được quyền cho các _field làm public,
        //vì vi phạm tính đóng gói (encapsulation), tất cả public thì sẽ rất nguy hiểm
        //Chế thêm biến - lai - với hàm get - set (trai bao, tiếp tân nhà bếp)
    }
}
