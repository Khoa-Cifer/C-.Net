using Euro.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euro.DAL.Repositories
{
    public class FootballTeamRepository
    {
        private GermanyEuro2024DbContext _context;

        public List<FootballTeam> GetAll()
        {
            _context = new();
            return _context.FootballTeams.ToList();
        }
    }
}
