using Euro.DAL.Models;
using Euro.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euro.BLL.Services
{
    public class UserService
    {
        private UserRepository _repository = new();

        public Uefaaccount CheckLogin(string email, string password)
        {
            return _repository.UserLogin(email, password);
        }
    }
}
