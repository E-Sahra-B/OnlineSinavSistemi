using Core.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IDersRepository : IRepository<Ders>
    {
        ICollection<Ders> DersleriGetir();
    }
}
