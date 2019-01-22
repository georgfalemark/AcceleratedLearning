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

        internal void AddRavioliForSpaceships(string spaceshipName, int numberOfCans, string packDate)
        {
            var spaceShip = _context.spaceShips.SingleOrDefault(s => s.Name == spaceshipName);

            if (spaceShip == null)
            {
                return;
            }

            List<Ravioli> list = new List<Ravioli>();

            for (int i = 0; i < numberOfCans; i++)
            {
                var r1 = new Ravioli { PackDate = packDate };
                list.Add(r1);
            }

            spaceShip.raviolis = list;

            _context.SaveChanges();
        }

        internal List<SpaceShip> GetAllSpaceships()
        {
            return _context.spaceShips.Include(s => s.raviolis).ToList();
        }
    }
}
