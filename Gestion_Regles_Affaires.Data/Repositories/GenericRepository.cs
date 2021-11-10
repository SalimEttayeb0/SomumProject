using Gestion_Regles_Affaires.Data.Context;
using Gestion_Regles_Affaires.Data.interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Regles_Affaires.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ReglesAffairesContext _context;
        private DbSet<T> table = null;
        public GenericRepository(ReglesAffairesContext context)
        {
            _context = context;
            table = _context.Set<T>();
        }
        public void Add(T entity)
        {
            table.Add(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(int id)
        {
            return table.Find(id);
        }

        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
