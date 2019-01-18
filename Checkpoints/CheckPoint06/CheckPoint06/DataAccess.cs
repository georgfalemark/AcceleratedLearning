using EntityFramework.Extensions;
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
            var ravioli = new Ravioli { NumberOfCans = v2, PackDate = v3 };
            _context.raviolis.Add(ravioli);
            _context.SaveChanges();
        }

        internal List<SpaceShip> GetAllSpaceships()
        {
            return _context.spaceShips.ToList();
        }
    }
}
