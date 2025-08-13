using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.PersistenceInterface;
using Test.Domain.Entity;
using Test.Infrastructure.Data;

namespace Test.Infrastructure.Repository
{
    public class ItemRepos : GenericRepos<Item>, IItem
    {
        private readonly ApplicationDbContext context;
        public ItemRepos(ApplicationDbContext _context) : base(_context)
        {
            context= _context;
        }
    }
}
