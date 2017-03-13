using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ImpulseBuy.Db
{
    public class SeedData
    {
        private ImpulseBuyContext _context;

        public SeedData(ImpulseBuyContext context)
        {
            _context = context;
        }

        public async Task EnsureSeedData()
        {

        }
    }
}
