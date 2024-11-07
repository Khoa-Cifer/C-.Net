using Euro.DAL.Models;
using Euro.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euro.BLL.Services
{
    public class PlayerService
    {
        private FootballPlayerRepository _repository = new();

        public List<FootballPlayer> GetAllFootballPlayers()
        {
            return _repository.GetAll();
        }
    }
}
