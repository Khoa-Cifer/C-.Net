using StudentTester.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTester.Services
{
    public class Cabinet
    {
        //cái tủ có ngăn chứa đủ rộng để lưu hồ sơ sinh viên
        //Xải mảng đi kèm biến count
        private Student[] _arr;
        private int _count = 0;

        //Câu hỏi 1: Tại sao tui lại không làm property
        //Câu hỏi 2: Cái tủ này bị fix 500 chỗ, những ngành khác cần ít hơn, vậy đóng tủ có kích thước theo nhu cầu, làm được không

        //Khong tao get/set cho cabinet, vi:
        //Voi get: get _arr ra, khong biet data da duoc fill toi dau, error.
        //Voi set: set lai gia tri cua _arr va _count la khong nen.
        //De tao cai tu theo yeu cau, nguoi dung phai dua size qua constructor luc khai bao, thi luc do cai tu co gia tri duoc custom se duoc tao ra

        public Cabinet(int size)
        {
            if (size < 1)
            {
                size = 69;
            }
            _arr = new Student[size];
        }

        //public Cabinet(int size)
        //{
        //    if (size < 1)
        //    {
        //        throw new ArgumentException("Invalid size! size must be >= 1");
        //    }
        //    _arr = new Student[size];
        //}

        //Co class va constructor la ta new duoc vo so objects
        //Doi khi co nhung class ta chi muon tao dung 1 object
        //De lam duoc dieu nay, ta can ki thuat goi la singleton.
        //De lam singleton, thi can hieu ro static

        //Design pattern, liet ke 23 mau thiet ke class noi tieng, ap dung cho nhung dang bai toan lap trinh.
        //Co mang 500 phan tu, co mang 500 bien student, co mang size phan tu, bay gio ta gan gia tri cho mang
        //_arr[i] = new Student() {}
        //_count++, de for sau nay

        //Overloading, overloading
        public void AddStudent(Student student) => _arr[_count++] = student; //expression body
        public void AddStudent(string id, string name, int yob, double gpa)
        {
            _arr[_count] = new Student() { Id = id, Name = name, Yob = yob, Gpa = gpa };
            _count++;
        } //TODO: Check mảng full hay không rồi mới add
        //In
        public void PrintStudentList()
        {
            Console.WriteLine($"There is/are {_count} student(s) in the list");
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }

        //Sửa thông tin 1 sinh viên, xoà thông tin 1 sv
        //Lưu ý: không có xoá mảng, mạng lớn bao nhiêu, kích thước trong ram to bấy nhiêu
        //Xoá phần tử thứ I của mảng, ko làm kích thước thật của mảng bị giảm.
        //Biến thứ i:           [0]     [1]     [2]     [3]     [4]
        //Giá trị phần tử:       5      10      15      20      25
        //Xoá vị trí số 2
        //Dồn từ chỗ xoá và cuối mảng lên 1 vị trí
        //                  [2] = [3], [3] = [4]
        public void RemoveStudent()
        {
            //Đưa vào mã sv, id, tìm ra vị trí muốn xoá
            //Xoá ở vị trí mấy, và đôn vị trí lên từ chỗ tìm thấy.
        }

        public void UpdateStudent(string id, string? newName, int? newYob, double? newGpa)
        {
            //Tìm vị trí của sinh viên có ID đưa vào
            int? pos = searchStudentById(id);//vi trí tìm thấy;
                                             //Đổi tên
            if (pos.HasValue)
            {
                _arr[(int)pos].Name = newName;
                Console.WriteLine("Update successfully");
            }
            else
            {
                Console.WriteLine("Student not found");
            }
            //if (newYob != null) {
            //    _arr[pos].Yob = newYob;
            //}
            //_arr[pos].Gpa = newGpa;

        }

        //Đưa id trả về vị trí
        //Quét hết mảng để tìm vị trí, hỏi từng đứa 1, tìm id match id đưa vào
        //return null quy ước không thấy
        //so sánh chuỗi, chuỗi là biến object, 2 biến so sánh ==, là so sánh địa chỉ, toạ độ -> sai
        //Java: SO sánh = cách gọi hàm s1.equalIgnoreCase(s2);
        //C#: Gài toán tử ==, dùng so sánh chuỗi cho tự nhiên
        //C#: độ lại ==, vốn dành cho so sánh số
        //2 chuỗi khi so sánh bị ảnh hưởng bởi hoa thường
        //convert cùng hoa, thường
        public int? searchStudentById(string id)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_arr[i].Id.ToLower() == id.ToLower())
                {
                    return i; //Tìm thấy tại vị trí thứ i
                }
            }
            //Đi hết for mà không thoát được, return null
            return null;
        }
    }
}

//BTVN: 15/10/2024, slot 3
//1. Hoàn tất nốt hàm xoá sinh viên, ghi ra giấy !!!
//2. Hoàn tất nốt hàm cập nhật sinh viên, ghi ra giấy !!!