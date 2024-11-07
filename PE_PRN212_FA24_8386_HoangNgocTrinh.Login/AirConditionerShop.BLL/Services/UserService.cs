using AirConditionerShop.DAL.Entities;
using AirConditionerShop.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirConditionerShop.BLL.Services
{
    public class UserService
    {
        //GUI --- SERVICE --- REPO --- DBCONTEXT --- TABLE
        //CLASS NÀY CUNG CẤP HÀM AUTHENTICATE() XÁC THỰC 1 ACCOUNT GÕ TỪ MÀN HÌNH LOGIN
        //NÓ GỌI XUỐNG REPO CHECK GIÙM, HOẶC NHẬN VỀ NULL, HOẶC NHẬN 1 VỀ 1 ACCOUNT TỨC LÀ 1 OBJECT THUỘC class StaffMember
        private UserRepository _repo = new(); //new luôn okie do nó xa DbContext

        //email và pass từ GUI Login
        public StaffMember? Authenticate(string email, string pass)
        {
            return _repo.GetOne(email, pass);
        }


    }
}
