﻿using Core.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IKullaniciCevapRepository : IRepository<KullaniciCevap>
    {
        List<KullaniciCevap> KullaniciCevaplari();

    }
}
