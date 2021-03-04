using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class KisiManager : IKisiService
    {
        private readonly IKisiDal db;

        public KisiManager(IKisiDal dal)
        {
            db = dal;
        }
        public void Delete(Kisi entity)
        {
            db.Delete(entity);
        }

        public async Task<List<Kisi>> GetAll()
        {
            return await db.GetAll();
        }

        public Kisi GetById(int id)
        {
            return db.GetById(id);
        }

        public void Insert(Kisi entity)
        {
            db.Insert(entity);
        }

        public void Update(Kisi entity)
        {
            db.Update(entity);
        }
    }
}
