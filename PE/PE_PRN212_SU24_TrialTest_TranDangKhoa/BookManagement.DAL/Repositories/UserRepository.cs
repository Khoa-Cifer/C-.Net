using BookManagement.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.DAL.Repositories
{
    public class UserRepository
    {
        private BookManagementDbContext _context;

        public UserAccount CheckLogin(string email, string password)
        {
            _context = new BookManagementDbContext();
            return _context.UserAccounts.FirstOrDefault(ua => ua.Email.ToLower() == email.ToLower() && ua.Password == password);
        }
    }
}
