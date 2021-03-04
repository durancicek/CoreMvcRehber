using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concreat.EFCore.MsSql
{
    public class KisiDal:MsSqlGenericRepository<Kisi>,IKisiDal
    {
    }
}
