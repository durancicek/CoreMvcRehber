using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IKisiService
    {
        void Insert(Kisi entity);
        void Update(Kisi entity);
        void Delete(Kisi entity);
        Kisi GetById(int id);
        Task<List<Kisi>> GetAll();
    

    }
}
