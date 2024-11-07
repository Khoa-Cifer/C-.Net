using Euro.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euro.DAL.Repositories
{
    public class UserRepository
    {
        private GermanyEuro2024DbContext _context;

        public Uefaaccount UserLogin(string email, string password)
        {
            _context = new();
            return _context.Uefaaccounts.FirstOrDefault(u => u.AccountEmail.ToLower() == email.ToLower() && u.AccountPassword == password);
        }
    }
}
