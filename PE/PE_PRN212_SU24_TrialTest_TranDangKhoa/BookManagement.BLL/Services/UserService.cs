using BookManagement.DAL.Models;
using BookManagement.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.BLL.Services
{
    public class UserService
    {
        private UserRepository _repository = new();
        public UserAccount GetAccount(string email, string password)
        {
            return _repository.CheckLogin(email, password);
        }
    }
}
