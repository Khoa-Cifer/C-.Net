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

        //Hàm này nhận vào 1 object cần xoá, là 1 vùng new AirCon
        //Trong biến obj muốn xoá phải đưa vào hàm, trong dbSet này sẽ lấy Id của airCon được đưa vào để xoá (DELETE WHERE Id...)
        public void DeleteAirConditioner(AirConditionerShop airConditioner)
        {
            //Xài là phải new, mỗi lần xài là phải new lại _dbContext;
            _dbContext.AirConditioners.Remove(airConditioner);
            _dbContext.SaveChanges();
        }

        public void AddAirConditioner(AirConditionerShop airConditioner)
        {
            //Xài là phải new, mỗi lần xài là phải new lại _dbContext;
            _dbContext.AirConditioners.Add(airConditioner);
            _dbContext.SaveChanges(); //tạo mới trong db và lưu thay đổi
        }

        public void UpdateAirConditioner(AirConditionerShop airConditioner)
        {
            //Xài là phải new, mỗi lần xài là phải new lại _dbContext;
            _dbContext.AirConditioners.Update(airConditioner);
            _dbContext.SaveChanges(); //update trong db và lưu thay đổi
        }
    }
}
