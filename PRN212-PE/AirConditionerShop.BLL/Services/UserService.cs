using AirConditionerShop.DAL.Models;
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
        //GUI -- Service -- Repository -- DBContext -- Table
        private UserRepository _repository = new UserRepository();

        //Dùng để check xem user login có hợp lệ hay không
        public StaffMember Authenticate(string email, string password)
        {
            return _repository.GetUserByLogin(email, password);
        }
    }
}
