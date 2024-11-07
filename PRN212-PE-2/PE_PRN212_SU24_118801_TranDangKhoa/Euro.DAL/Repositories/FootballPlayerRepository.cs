using Euro.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euro.DAL.Repositories
{
    public class FootballPlayerRepository
    {
        private GermanyEuro2024DbContext _context;

        public List<FootballPlayer> GetAll()
        {
            _context = new();
            return _context.FootballPlayers.Include(fp => fp.FootballTeam).ToList();
        }
    }
}
