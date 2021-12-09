using Core.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IKursMerkeziRepository : IRepository<KursMerkezii>
    {
        ICollection<KursMerkezii> IlSec(string il);
        ICollection<KursMerkezii> IlceSec(string ilce);
    }
}
