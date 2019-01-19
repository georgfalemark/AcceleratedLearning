using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckPoint06
{
    public class DataAccess
    {
        private readonly SpaceShipContext _context;

        public DataAccess()
        {
            _context = new SpaceShipContext();
        }

        internal void AddSpaceships(string v)
        {
            var spaceShip = new SpaceShip { Name = v, };
            _context.spaceShips.Add(spaceShip);
            _context.SaveChanges();
        }

        internal void AddRavioliForSpaceships(string v1, int v2, string v3)
        {
            for (int i = 0; i < v2; i++)
            {
                using (var _context = new SpaceShipContext())
                {
                    var result = _context.spaceShips.SingleOrDefault(s => s.Name == v1);
                    if (result != null)
                    {
                        result.raviolis = new List<Ravioli> { new Ravioli { PackDate = v3 } };
                        _context.SaveChanges();
                    }
                }
            }

        }

        internal List<SpaceShip> GetAllSpaceships()
        {
            return _context.spaceShips.Include(s => s.raviolis).ToList();
        }
    }
}
