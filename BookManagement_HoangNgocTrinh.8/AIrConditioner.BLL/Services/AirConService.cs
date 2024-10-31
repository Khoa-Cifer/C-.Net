using AirConditioner.DAL.Models;
using AirConditioner.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIrConditioner.BLL.Services
{
    public class AirConService
    {
        //Thằng này bị GUI gọi, vì nó có data trong ram
        //Nó di nhờ vả thằng Repository lấy data giúp, service đứng giữa truyền qua
        private AirConditionerRepository _repository = new();

        public List<AirConditionerShop> GetAll()
        {
            return _repository.GetAll();
        }

        public void DeleteAirConditioner(AirConditionerShop airConditionerShop) =>
            _repository.DeleteAirConditioner(airConditionerShop);

        public void UpdateAirConditioner(AirConditionerShop airConditionerShop) =>
          _repository.UpdateAirConditioner(airConditionerShop);

        public void CreateAirConditioner(AirConditionerShop airConditionerShop) =>
          _repository.AddAirConditioner(airConditionerShop);
    }
}
