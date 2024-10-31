using AirConditioner.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirConditioner.DAL.Repositories
{
    public class SupplierCompanyRepository
    {
        private AirConditionerShop2024DbContext _context;

        //Lấy tất cả hàng và cột của table
        public List<SupplierCompany> GetAll()
        {
            _context = new AirConditionerShop2024DbContext();
            return _context.SupplierCompanies.ToList();
        }
    }
}
