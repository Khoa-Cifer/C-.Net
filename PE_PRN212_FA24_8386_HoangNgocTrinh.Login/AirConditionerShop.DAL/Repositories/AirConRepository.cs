using AirConditionerShop.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirConditionerShop.DAL.Repositories
{
    public class AirConRepository
    {
        //THẰNG NÀY CHƠI TRỰC TIẾP VỚI DBCONTEXT, NHỜ NÓ CRUD TABLE MÁY LẠNH
        //NẾU A NHỜ B, THÌ A PHẢI KHAI BÁO BIẾN CỦA B
        private AirConditionerShop2024DbContext _context; //lúc nào xài mới new

        //CRUD MÁY LẠNH, nhờ thằng context giúp
        public List<AirConditioner> GetAll()
        {
            _context = new AirConditionerShop2024DbContext();
            //return _context.AirConditioners.ToList(); //ko join
        
            return _context.AirConditioners.Include("Supplier").ToList();
        
        }  //JOIN 2 BẢNG QUA NAVIGATION PATH, BIẾN ĐỐI TƯỢNG NCC
          //VÌ 1 MÁY LẠNH THUỘC VỀ, CÓ INFO CỦA NCC NÓI CHUNG - OBJ SUPP-COMPANY 
        
        //select * from table AirCon 
        //trả về DbSet, giống List, ta convert sang List

        //HÀM NHẬN VÀO 1 OBJECT CẦN XOÁ, LÀ 1 VÙNG NEW AIR-CON
        //TRONG BIẾN OBJ MUỐN XOÁ ĐƯA VÀO HÀM, THÌ PHÍA HẬU TRƯỜNG CỦA DBCONTEXT, NÓ obj.GetID máy lạnh và where trên table thật
        public void Delete(AirConditioner obj)
        {
            _context = new();  //mỗi lần xài 1 lần new _context
            _context.AirConditioners.Remove(obj); //trong ram
            _context.SaveChanges(); //chính thức xoá trong db
        }
        public void Create(AirConditioner obj)
        {
            _context = new();  //mỗi lần xài 1 lần new _context
            _context.AirConditioners.Add(obj); //trong ram
            _context.SaveChanges(); //chính thức tạo mới trong db
        }

        public void Update(AirConditioner obj)
        {
            _context = new();  //mỗi lần xài 1 lần new _context
            _context.AirConditioners.Update(obj); //trong ram
            _context.SaveChanges(); //chính thức update trong db
        }

        //Lma2 hàm search trên 2 ô nhập từ GUI
        //số và text, search là and hoặc là or
        public List<AirConditioner> SearchAirConFeatureOrQuantity(string feature, int? quantity)
        {
            _context = new();
            List<AirConditioner> result = _context.AirConditioners.Include(ac => ac.Supplier).ToList();
            //không gõ gì cả vào 2 ô, thì show hết
            if (string.IsNullOrEmpty(feature) && quantity == null)
            {
                return result;
            }

            //User gõ cả 2 ô text và số, mệnh đề OR
            if (!string.IsNullOrEmpty(feature) && quantity != null)
            {
                return result.Where(x => x.FeatureFunction.ToLower().Contains(feature.ToLower()) || x.Quantity == quantity).ToList();
            }

            //User gõ text
            if (!string.IsNullOrWhiteSpace(feature))
            {
                return result.Where(x => x.FeatureFunction.ToLower().Contains(feature.ToLower())).ToList();
            }

            //Tình huống user gõ số, ko gõ text
            return result.Where(x => x.Quantity == quantity).ToList();
            //Nếu 2 ô search dùng and, thì chỉ cần thay || bằng &&
        }
    }
}
