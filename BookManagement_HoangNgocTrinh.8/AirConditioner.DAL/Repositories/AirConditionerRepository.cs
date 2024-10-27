using AirConditioner.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirConditioner.DAL.Repositories
{
    public class AirConditionerRepository
    {
        //Thằng này chơi trực tiếp với DB Context, nhờ nó CRUD table máy lạnh
        //Nếu A nhờ B, thì A phải khai báo biến của B
        private AirConditionerShop2024DbContext _dbContext; //Không new, lúc nào xài mởi new

        //CRUD máy lạnh, nhờ dbContext giúp
        public List<AirConditionerShop> GetAll() 
        {
            _dbContext = new AirConditionerShop2024DbContext();
            return _dbContext.AirConditioners.ToList();
        }
    }
}
