using Microsoft.EntityFrameworkCore;
using ProjectTry.Coree.Interfaces;
using ProjectTry.Infrastructuree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectTry.Infrastructure.Repositories
{
    
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        protected readonly DbContextClass _dbContext;

        public GenericRepository(DbContextClass context)
        {
            _dbContext = context;
        }

        public async Task<T> GetById(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task Add(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async void Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async void Update(T entity)
        {
            _dbContext.Set<T>().Update(entity);
            await _dbContext.SaveChangesAsync();    
        }

    }
}
