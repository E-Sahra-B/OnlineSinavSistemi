using Core.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IKullaniciSinavService
    {
        ResultMessage<KullaniciSinav> Add(KullaniciSinav data);
        ResultMessage<KullaniciSinav> Update(KullaniciSinav data);
        ResultMessage<KullaniciSinav> SoftDelete(int id);
        ResultMessage<ICollection<KullaniciSinav>> GetAll(Expression<Func<KullaniciSinav, bool>> filter = null);
    }
}
