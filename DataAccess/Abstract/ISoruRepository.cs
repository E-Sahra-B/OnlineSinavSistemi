using Core.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ISoruRepository : IRepository<Soru>
    {
        ICollection<Soru> BransSorulari(int bransSorulari);
    }
}
