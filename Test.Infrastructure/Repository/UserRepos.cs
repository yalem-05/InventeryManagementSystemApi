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
    public class UserRepos : GenericRepos<User>, IUser
    {
        private readonly ApplicationDbContext context;
        public UserRepos(ApplicationDbContext _context) : base(_context)
        {
            context= _context;
        }
    }
}
