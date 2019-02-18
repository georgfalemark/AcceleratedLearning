using HemNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HemNet.Views
{
    public class AppartmentSortVm
    {
        public IEnumerable<Apartment> Apartments { get; set; }
        public int CurrentSort { get; set; }
    }
}
