using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//package java.util
//Dấu chấm dùng để phân cấp các tầng thư mục (Folder/Directory) trong source code, tập tin source code
//Khi xài thì phải nói mình lấy class ở đâu để mình new/clone -> Chỉ ra class ở đâu, lấy ra dùng -> Import (bên Java) hay Using (bên C#)
namespace StudentTester.Entities
{
    public class Student
    {
        //Class có gì
        //Fields và Methods (Gọi chung là members of a class)
        //Giống như 1 cái Form, biểu mẫu, dàn khung, cái khuôn, bản phác thảo Blue-Print
        private string _id; 
        private string _name;
        private int _yob;
        private double _gpa;

        public Student(string id, string name, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }

        public Student(string id, string name)
        {
            _id = id;
            _name = name;
        }


        //Khi object đã được tạo ra, được đổ đầy info, ta flex thông tin
        public void FlexProfile() => Console.WriteLine($"{_id} {_name} {_gpa} {_yob}");
        //Expression body

        //Một object được tạo ra, ta sẽ có như cầu
        //Flex từng miếng thông tin, giống như khi ta tạo account fb, ta chỉ khoe 1 số info
        //- > Hàm getter sẽ return _Biến
        //Chỉnh sửa thông tin nào đó đã được đổ trước đó
        //Chỉnh cover, chỉnh world paper, chọn sóng wifi
        //- > Hàm setter chỉnh sửa nhận vào info cần update
        //Có bao nhiêu fields, có bấy nhiêu cặp get/set
        public string GetId()
        {
            return _id;
        }

        public string GetName() => _name;
        public int GetYob() => _yob;
        public double GetGpa() => _gpa;
        public void SetId(string id)
        {
            _id = id;
        }
        public void SetName(string name)
        {
            _name = name;
        }
        public void SetYob(int yob)
        {
            _yob = yob;
        }
        public void SetGpa(double gpa) => _gpa = gpa;

        ///Constructor mỗi lần được gọi là phải đi kèm với toán tử new, là đúc 1 object mới -> Tốn 1 vùng ram mới để chứa object vừa được khởi tạo
        //Như việc tạo mới 1 account fb
        //Hàm set có code giống như constructor, nhận đầu vào, nhận đầu vào, modify bên trong object, nhưng nó là hàm gắn với hành động của từng object đã được new.
        //Có thể được gọi nhiều lần, nhưng chỉ gọi trên object đã được new trước đó bởi constructor.
        //Nghĩa là constructor tạo object trong RAM, get set thao tác trên vùng ram vừa được new bởi object.
        //Giống mình cập nhận avatar, n lần, ko bị ảnh hưởng bởi người khác.
        //Gọi kèm cùng object.
        
        //New và Constructor: Tương đương apple new, đưa vào sx các phone
        //Get/Set: Ngắm, chỉnh, thiết lập phone đã mua.

        //Có bao nhiêu fields, bấy nhiêu field x 2 các hàm get/set
        //Có 4 field, có 8 hàm get set
        //Đây là những hàm quan trọng, vì có nó thì mới get set được thông tin 1 object
        //Code phải làm nhưng nhàm chán => Gọi là boiler plate

        //Có cách nào giúp đỡ mất thời gian, mất sức gõ get set hay không, làm get set thú vị hơn, tiết kiệm thời gian hơn
        //Tối nay mình có hẹn hò, 20:30


    }
}

//Quy tắc viết code - CODING CONVENTION -- cách đặt tên cho các thứ ở trong code
//I. Tên Solution
//II. Tên Project
//III. namespace
//IV. Class (Interface) Delegate
//* Tên Class có gì đặc biệt, phải là danh từ, Pascal Case, Chữ Hoa Từ.
//* Vd: Student, Lecturer, String, Employee, StringTokenize, StringBuffer /Giống Java
//V. Fields (Instance Variables, Local Variables)
//1. Fields Non-Static (Instance Variables);
//- Noun, cú pháp con lạc đà, camel Case Notation
//Chữ hoa tường đầu từ, từ đầu tiên viết chữ thường, kèm _ đầu từ
//* Vd: _id, _name, _receiverAddress, ...

//2. Biến Cục Bộ (Biến được khai báo trong hàm, trên tham số hàm);
//- Noun, cú pháp con lạc đà, camel Case Notation
//Chữ hoa tường đầu từ, từ đầu tiên viết chữ thường, kèm _ đầu từ
//* Vd: id, name, receiverAddress, ...

//VI. Methods (Hàm)
//* Tên hàm phải là: Verb + Object()
//* Tên hàm phải theo Pascal Case Notation
//Chữ Hoa Từng Đầu Từ kể cả từ đầu tiên
//* Vd: FlexProfile(), GetName(), SetName(...)

//Trong các hàm có 1 hàm rất đặc biệt, đó là constructor
//Constructor là cái phễu, hứng vật liệu đưa vào để tạo ra object với full thông tin đã được đổ vào qua toán tử new
//Quy tắc đặt tên constructor
//- Tên Constructor trùng 100% cả hoa thường với tên class,
//- Không có giá trị trả về, vì nó sẽ trả về nguyên Object với full thông tin đã được đổ vào qua toán tử new.
//- 