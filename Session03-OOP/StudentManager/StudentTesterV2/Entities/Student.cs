using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTesterV2.Entities
{
    public class Student
    {
        private string _id;
        private string _name;
        private string _email;
        private double _gpa;

        //1 class có thể có nhiều constructors, 1 bức tượng có nhiều cách để đúc
        //Tượng 1/2, tượng full người, chất liệu,...

        //Nếu 1 class không có constructor thì runtime tự tạo ra 1 constructor ngầm, không nói rõ ra (Implicit constructor), constructor này không nhận đầu vào, không nhận đầu ra, nhưng nó giúp ta gọi kèm toán tử new để xin vùng ram lưu object.

        //Ngoài đời: Cô giao dịch viên đưa ta 1 cái form trống để ta điền info vào khi làm thủ tục ngân hàng
        //Vậy nếu class có constructor tự sinh ra (Constructor default, constructor rỗng) vậy object được tạo ra sẽ có hình dáng
        //Mọi field bên trong sẽ mang default value của nó luôn
        //string: null
        //số: 0
        //bool: false

        public override string ToString() => $"{_id} {_name} {_email} {_gpa}";

        //Nếu class có 1 constructor khác, runtime ko tạo giúp constructor default nữa
        //1 class cần ít nhất 1 cái phễu để đúc object;

        public Student(string id, string name, string email)
        {
            _id = id;
            _name = name;
            _email = email;
        }

        //Nhưng bạn có thể chủ động tạo 1 constructor rỗng, không chờ tự sinh, explicit constructor
        public Student() { }
    }
}
