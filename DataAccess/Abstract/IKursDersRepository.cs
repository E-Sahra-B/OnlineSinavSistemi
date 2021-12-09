using Core.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IKursDersRepository : IRepository<KursDers>
    {
        ICollection<Kullanici> KursunKullanicilariniGetir(int id);
        ICollection<Ders> KursunDersleriniGetir(int id);
    }
}
