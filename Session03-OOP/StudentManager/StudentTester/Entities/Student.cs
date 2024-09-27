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

        //Khi object đã được tạo ra, được đổ đầy info, ta flex thông tin
        public void FlexProfile() => Console.WriteLine($"{_id} {_name} {_gpa} {_yob}");
        //Expression body
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