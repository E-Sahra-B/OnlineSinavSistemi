﻿using Core.Concrete;
using System;

namespace Business.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IBransService Brans { get; }
        IDersService Ders { get; }
        IKullaniciCevapService KullaniciCevap { get; }
        IKullaniciService Kullanici { get; }
        IKullaniciSinavService KullaniciSinav { get; }
        IKursDersService KursDers { get; }
        IKursService Kurs { get; }
        IKursMerkeziService KursMerkezi { get; }
        IRolService Rol { get; }
        ISikayetService Sikayet { get; }
        ISinavService Sinav { get; }
        ISinavSoruService SinavSoru { get; }
        ISoruService Soru { get; }
        IYorumService Yorum { get; }
        //int SaveChanges { get; }
        ResultMessage<int> SaveChanges();
    }
}
