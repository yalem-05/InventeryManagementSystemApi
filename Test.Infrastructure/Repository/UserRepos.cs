using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Dto;
using Test.Application.PersistenceInterface;
using Test.Domain.Entity;
using Test.Infrastructure.Data;

namespace Test.Infrastructure.Repository
{
    public class UserRepos : GenericRepos<User>, IUser
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
        public UserRepos(ApplicationDbContext _context, IMapper _mapper) : base(_context)
        {
            context= _context;
            mapper= _mapper;
        }

        public async Task<List<Item>> GetAllDataWithId(Guid Id)
        {
          var data= await context.items
                   .Where(p => p.UserId == Id)
                   .Include(p => p.users)
                   .ToListAsync();
             return data;
        }

        public async Task<GetUserDto> GetUserByName(string fname)
        {
            
            var data= await context.users.FirstOrDefaultAsync(u=>u.Fname==fname);
           
            return mapper.Map<GetUserDto>(data);
            //throw new NotImplementedException();
        }
    }
}
