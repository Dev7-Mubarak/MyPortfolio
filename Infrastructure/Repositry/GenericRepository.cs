using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositry
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private AppDbContext _context;
        private DbSet<T> table = null!;
        public GenericRepository(AppDbContext context)
        {
            _context = context;
            table = _context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(object Id)
        {
            return table.Find(Id);
        }

        public void Insert(T entity)
        {
            table.Add(entity);
        }

        public void Delete(object Id)
        {
            T Exsist = GetById(Id);
            table.Remove(Exsist);
        }

        public void Update(T entity)
        {
            table.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
