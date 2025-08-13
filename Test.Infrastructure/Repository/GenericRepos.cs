using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Domain.IGenericInterfave;
using Test.Infrastructure.Data;

namespace Test.Infrastructure.Repository
{
    public class GenericRepos<T> : IGeneric<T> where T : class
    {
        private readonly ApplicationDbContext context;
        public GenericRepos(ApplicationDbContext _context)
        {
            context= _context;
        }
        public async Task<T> addData(T entity)
        {
             context.Set<T>().Add(entity);
            await context.SaveChangesAsync();
            return entity;
            //throw new NotImplementedException();
        }

        public async Task<T> deleteById(T entity)
        {
     context.Set<T>().Remove(entity);
            await context.SaveChangesAsync();
            return entity;
            //throw new NotImplementedException();
        }

        public  async Task<List<T>> GetAll()
        {
            var entity=await  context.Set<T>().ToListAsync();
            return entity;
            //throw new NotImplementedException();
        }

        public async Task<T> GetById(Guid id)
        {
            var data= await context.Set<T>().FindAsync(id);
            if (data != null)
            {
                return data;
            }
         
           throw new KeyNotFoundException("this element with {id} not found");
        }

        public async Task<T> updateData(T entity)
        {
            context.Set<T>().Update(entity);
            await context.SaveChangesAsync();
            return entity;
            //throw new NotImplementedException();
        }

      
    }
}
