using AirConditionerShop.DAL.Entities;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirConditionerShop.DAL.Repositories
{
    public class UserRepository
    {
        //GUI --- SERVICE --- REPO --- DBCONTEXT --- TABLE

        //THEO TRUYỀN THỐNG, THÌ REPO CHƠI TRỰC TIẾP TABLE QUA DBCONTEXT, VÀ NÓ CHỨA CÁC HÀM CRUD TABLE TƯƠNG ỨNG
        //VỚI BÀI NÀY, THÌ USER-REPO SẼ CHỨA CÁC HÀM CRUD TABLE STAFF-MEMBER
        //BÀI THI PE KO YÊU CẦU CRUD USER, BÀI SWP391 CẦN CRUD USER
        //BÀI THI PE TA KO LÀM CRUD USER,

        //TA LÀM 1 HÀM DUY NHẤT ĐỂ GIÚP MÀN HÌNH LOGIN CHECK 1 ACCOUNT CÓ TỒN TẠI HAY KO
        //ACCOUNT ĐC XÉT THEO EMAIL-ADDRESS VÀ PASSWORD
        //HÀM LOGIN CHÍNH LÀ:
        //   SELECT * FROM STAFFMEMBER WHERE EMAILADDRESS = EMAIL GÕ Ở LOGIN
        //                   AND PASSWORD = PASS GÕ Ở LOGIN
        //HÀM NÀY SẼ TRẢ VỀ 1 DÒNG DUY NHẤT NẾU MATCH EMAIL VÀ PASS
        //HOẶC TRẢ VỀ KO GÌ CẢ, KO CÓ DÒNG NÀO, NULL CỦA ENTITY StaffMember

        private AirConditionerShop2024DbContext _context; //ko new cho đến khi gọi nó

        //public List<StaffMember> GetAll()
        //{
        //    //truyền thống trả về full các user/account
        //}

        //EMAIL VÀ PASS TỪ GUI -> SERVICE -> HÀM NÀY
        public StaffMember? GetOne(string email, string pass)
        {
            _context = new();  //new Context() trước khi dùng
            //return _context.StaffMembers.ToList(); //join thêm .Include()
            //return _context.StaffMembers.FirstOrDefault(where trên email và pass);
            return _context.StaffMembers.FirstOrDefault(x => x.EmailAddress.ToLower() == email.Trim().ToLower() && x.Password == pass);

        }

    }
}

//NGOẠI TRUYỆN: SO SÁNH CHUỖI - SO SÁNH CHUỖI VÌ EMAIL VÀ PASS LÀ CHUỖI GÕ TỪ BÀN PHÍM, TỪ MÀN HÌNH LOGIN
//TRONG JAVA, C#, VÀ CÁC NNLT OOP, THÌ CHUỖI/STRING LÀ KIỂU OBJECT
//TỨC LÀ ĐỂ LƯU 1 CHUỖI TRONG RAM TA CẦN 1 VÙNG NEW STRING(...) {...}
//biến String s trong Java
//biến string s trong C# 
//BẢN CHẤT LÀ TRỎ VÀO VÙNG NEW CHỨA 1 ĐỐNG KÍ TỰ (CHUỖI)
//VẬY NẾU SO SÁNH 2 BIẾN CHUỖI, String s1 = "..."; String s2 = ...
//                              string s1 = "..."; string s2 = ...
//MÀ DÙNG TOÁN TỬ == 
//               if (s1 == s2) 
//BẢN CHẤT LÀ SO SÁNH TOẠ ĐỘ 2 VÙNG NEW, SO SÁNH 2 ĐỊA CHỈ RAM, SO SÁNH 2 SỐ NHÀ NƠI VÙNG NEW STRING() ĐANG CƯ NGỤ
//ĐIỀU NÀY LÀ VÔ NGHĨA
//TRONG JAVA: SO SÁNH 2 CHUỖI KO DÙNG == MÀ PHẢI DÙNG HÀM CỦA TỪNG BIẾN CHUỖI, TỨC LÀ  s1.equals(s2) NGHĨA LÀ vùng NEW s1 CÓ HÀM equals()
//HÀM NÀY Ở TRONG VÙNG NEW, DƯ SỨC LẤY ĐƯỢC CHUỖI KÍ TỰ ĐỂ ĐI SO SÁNH VỚI CHUỖI KHÁC
//VẬY SO SÁNH 2 BIẾN OBJECT NÓI CHUNG, 2 BIẾN CHUỖI NÓI CHUNG KO DÙNG TOÁN TỬ == MÀ ĐI DÙNG HÀM, CHẤM HÀM SO SÁNH()
//VÌ == ĐC DÙNG ĐỂ SO SÁNH 2 GIÁ TRỊ THUẦN, 2 BIẾN PRIMITIVE, 2 VALUE NÀO ĐÓ MÀ KO LÀ OBJECT

//C# CÙNG KHÁI NIỆM VỚI JAVA, NHƯNG VÌ SO SÁNH CHUỖI RẤT HAY DÙNG, NÊN C# ĐÃ QUYẾT ĐỊNH CHẾ LẠI CÁI == ĐỂ ĐC DÙNG VỚI CHUỖI LUÔN, VÀ ĐÓ LÀ SO SÁNH 2 CHUỖI BÊN TRONG, KO SO SÁNH ĐỊA CHỈ
//VẬY VỚI C# DÙNG == ĐỂ SO SÁNH 2 CHUỖI LUÔN (C# OVERRIDE TOÁN TỬ == VỐN DÀNH CHO PRIMITIVE)

//CẢ C# VÀ JAVA KHI SO SÁNH 2 CHUỖI, MẶC ĐỊNH KO NÓI NĂNG GÌ CẢ, THÌ PHÂN BIỆT HOA THƯỜNG, TỨC LÀ A HOA KHÁC a thường
//NẾU MUỐN KO QUAN TÂM HOA THƯỜNG, TỨC LÀ CỨ CÓ a A là như nhau
//THÌ PHẢI GHI RÕ (IGNORE CASE)

//VẬY BÀI LOGIN, EMAIL KO PHÂN BIỆT HOA THƯỜNG, GÕ LOGIN HOA THƯỜNG OKIE LUÔN, TA DÙNG == NHƯNG PHẢI ĐỔI TRƯỚC 2 THẰNG THÀNH LOWER, UPPER
//CÒN PASSWORD THÌ ĐỂ IM, CỨ SO SÁNH == BÌNH THƯỜNG, TỨC LÀ PHÂN BIỆT HOA THƯỜNG -> TĂNG TÍNH BẢO MẬT 


