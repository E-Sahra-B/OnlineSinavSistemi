using Core.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ISikayetRepository : IRepository<Sikayet>
    {
        ICollection<Sikayet> SikayetleriGetir(int kullaniciid);
        ICollection<Sikayet> DersinSikayetleriniGetir(int dersid, int kullaniciid);
    }
   

}
