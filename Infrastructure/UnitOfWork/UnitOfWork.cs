using Core.Interfaces;
using Infrastructure.Repositry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        private AppDbContext _context;
        private IGenericRepository<T> _entity;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        public IGenericRepository<T> Entity {
            get =>  _entity?? (_entity = new GenericRepository<T>(_context)); 
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
