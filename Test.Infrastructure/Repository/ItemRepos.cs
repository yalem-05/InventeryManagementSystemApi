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
    public class ItemRepos : GenericRepos<Item>, IItem
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
        public ItemRepos(ApplicationDbContext _context, IMapper _mapper) : base(_context)
        {
            context= _context;
            mapper= _mapper;
        }

        public async Task<List<Item>> GetAllDataWithId(Guid Id)
        {
            var data = await context.items
                   .Where(p => p.UserId == Id)
                   .Include(p => p.users)
                   .ToListAsync();
            if (data == null)
            {
                throw new KeyNotFoundException("DATA ARE NOT FOUND HERE...");
            }

            return data;
        }

        public async Task<GetItemDto> GetItemByName(string itemName)
        {
            var data=await context.items.FirstOrDefaultAsync(U=>U.ItemName==itemName);
            return mapper.Map<GetItemDto>(data);
            //throw new NotImplementedException();
        }
    }
}
