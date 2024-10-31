using AirConditioner.DAL.Models;
using AirConditioner.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIrConditioner.BLL.Services
{
    public class SupplierService
    {
        //GUI gọi service -> repo -> dbContext
        private SupplierCompanyRepository _repository = new();

        public List<SupplierCompany> GetAllSuppliers()
        {
            return _repository.GetAll();
        }
    }
}
