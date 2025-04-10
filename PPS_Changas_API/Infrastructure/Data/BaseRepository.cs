using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class 
    {
        protected readonly DbContext _context;

        public BaseRepository(DbContext context)
        {
            _context = context;
        }

        public async Task<List<T>>  GetAll()
        {

            return _context.Set<T>().ToList();
        }

        public async Task<T> GetById(int id)
        {

            return _context.Set<T>().Find(new object[] { id });
        }

        public async Task Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();


        }

        public async Task<T> Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
            return entity;

        }

        public async Task<T> Create(T entity)
        {

            _context.Set<T>().Add(entity);
            _context.SaveChanges();
            return entity;


        }
    }
}
