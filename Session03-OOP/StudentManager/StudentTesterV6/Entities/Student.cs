using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTesterV6.Entities
{
    public class Student
    {
        public string Id { get; set; } //property này có đằng sau _id
        public string Name { get; set; }
        public int Yob { get; set; }
        public int Gpa { get; set; }

        public override string? ToString() => $"Student {Id} {Name} {Yob} {Gpa}";


        //Nếu bạn quên cú pháp, hãy gõ
        //public int MyProperty { get; set; }

        //Kĩ thuật che giấu đi _backingField để tránh rườm rà code, khi chạy, runtime tự generate cho ta _backingField
        //Kĩ thuật này gọi là Auto-Generated property
        //là sự rút gọn của full property

        //Property hay dùng khi map 1 class xuống table ở database
        //Không cần xử lí gì cả, chỉ insert object xuống table, get lên ram trở lại => Get Set là đủ cho class này

        //Muốn xử lí theo info sv, đậu rớt, sort điểm,... -> Lưu dữ liệu vào ram, vào mảng, vào list để xử lí

        //Java chuẩn không có kĩ thuật property, nhưng các anh em mạng bên java đã độ lại get set theo style ngắn gọn, tránh boiler pate
        //-> Dùng thư viện hãng thứ 3: Lombok //@Getter, @Setter
    }
}
