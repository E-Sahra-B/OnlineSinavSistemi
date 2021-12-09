using Core.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IKullaniciRepository : IRepository<Kullanici>
    {
        List<Kullanici> KullaniciMailListesi();

    }
}
