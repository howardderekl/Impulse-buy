using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ImpulseBuy.Db
{
    public class RepositoryBase
    {
        private ImpulseBuyContext _context;

        public RepositoryBase(ImpulseBuyContext context)
        {
            _context = context;
        }

        public virtual async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
    }
}
