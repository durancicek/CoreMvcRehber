using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concreat.EFCore.MsSql
{
    public class MsSqlGenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
       
        public void Delete(TEntity entity)
        {
            using (var db = new MsSqlDbContext())
            {
                db.Set<TEntity>().Remove(entity);
                db.SaveChanges();
            }

        }

        public async Task<List<TEntity>> GetAll()
        {
            using (var db = new MsSqlDbContext())
            {
                return await db.Set<TEntity>().ToListAsync();

            }


        }

        public TEntity GetById(int id)
        {
            using (var db = new MsSqlDbContext())
            {

                var result = db.Set<TEntity>().Find(id);
                return result;
            }
        }


        public void Insert(TEntity entity)
        {

            using (var db = new MsSqlDbContext())
            {
                db.Set<TEntity>().Add(entity);
                db.SaveChanges();
            }

        }

        public void Update(TEntity entity)
        {
            using (var db = new MsSqlDbContext())
            {
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }

        }
      

    }
}
