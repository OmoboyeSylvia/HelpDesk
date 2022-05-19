using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using static HelpDesk.Interface.IGeneric;
using System.Collections.Generic;
using HelpDesk.Repository;


namespace HelpDesk.Repository
{
    public class GenericRepository
    {
        public abstract class GenericRepository<T> : IGeneric<T> where T : class
        {
            protected readonly HelpDeskDBContext _context;

            protected GenericRepository(HelpDeskDBContext context)
            {
                _context = context;
            }

            public async Task<T> Get(int id)
            {
                return await _context.Set<T>().FindAsync(id);
            }

            public async Task<IEnumerable<T>> GetAll()
            {
                return await _context.Set<T>().ToListAsync();
            }

            public async Task Add(T entity)
            {
                await _context.Set<T>().AddAsync(entity);
            }

            public void Delete(T entity)
            {
                _context.Set<T>().Remove(entity);
            }

            public void Update(T entity)
            {
                _context.Set<T>().Update(entity);
            }
        }
    }
}
