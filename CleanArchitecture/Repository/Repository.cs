using Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;
        private DbSet<T> entities;
        private HttpContext httpContext;

        public Repository(AppDbContext context, HttpContext httpContext)
        {
            _context = context;
            this.entities = context.Set<T>();
            this.httpContext = httpContext;
        }

        public void Add(T entity)
        {
            entity.IpAddress = httpContext.Connection.RemoteIpAddress.ToString();
            entity.CreatedDate = DateTime.Now;
            _context.Entry(entity).State = EntityState.Added;
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            
            _context.Entry(entity).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public T GetById(int id)
        {
            return entities.FirstOrDefault(x => x.Id == id);
        }

       

        public void Update(T entity)
        {
            entity.IpAddress = httpContext.Connection.RemoteIpAddress.ToString();
            entity.ModifiedDate = DateTime.Now;
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public List<T> Where(Expression<Func<T, bool>> exp)
        {
            return entities.Where(exp).ToList();
        }
    }
}
