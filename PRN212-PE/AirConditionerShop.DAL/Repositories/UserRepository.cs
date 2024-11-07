using AirConditionerShop.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirConditionerShop.DAL.Repositories
{
    public class UserRepository
    {
        //GUI -- Service -- Repository -- DBContext -- Table
        //Về lý thuyết, 1 repository sẽ chứa các hàm crud table tương ứng, tức là thêm xoá sửa tìm kiếm user.
        //Bài thi PE không yêu cầu làm crud user, chỉ làm login
        //Dùng repo check staff-member có tồn tại hay không bằng cách xem cặp email/password -> Login
        //Vậy ta sẽ chế ra 1 hàm check login nhận vào email và password trả về 1 dòng trong table staff member, 1 dòng là 1 object StaffMember, nếu không thấy thì trả về null, user khong tồn tại
        //So sánh chuỗi trong Java đều là object, new chứa nhiều kí tự
        //Vậy nếu ta có 2 biến string, muốn so sánh có bằng nhau hay không, không được dùng toán tử ==
        //s1 == s2 là so sánh 2 biến object, là so sánh 2 toạ độ vùng new, là so sánh 2 địa chỉ -> Vô nghĩa
        //So sánh object chuỗi là đi vào trong chuỗi lấy kí tự mà so
        //s1.equals(s2); -> Trả về True/False
        //Với C# là tương tự, vì string là biến object, nhưng c# cho phép so sánh bằng ==, nhưng bản chất vẫn như nhau, vẫn vào theo con trỏ tìm ra object
        //Cả 2 khi so sánh 2 chuỗi nếu không nói gì cả thì mặc định là so sánh có phân biệt hoa thường, default sẽ so sánh phân biệt hoa thường (A và a) -> Dùng cho so sánh password được
        //Để so sánh email, ta cần convert hoa thường thành 1 thể, thì ta đổi 2 chuỗi về cùng thường (hoặc hoa)
        //s1.Equals(s2);

        private AirConditionerShop2024DbContext _dbContext;
        //Chỉ có nhu cầu trả về 1 account match với email, password nào đó từ màn hình login
        public StaffMember GetUserByLogin(string email, string password)
        {
            //Nhận từ GUI -> Service -> getUserByLogin
            _dbContext = new();
            return _dbContext.StaffMembers.FirstOrDefault(u => u.EmailAddress.ToLower() == email.ToLower() && u.Password == password); //hoặc trả về 1 object, không nó thì trả về null.
        }
    }
}
