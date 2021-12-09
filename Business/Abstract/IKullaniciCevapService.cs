using Core.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IKullaniciCevapService
    {
        ResultMessage<KullaniciCevap> Add(KullaniciCevap data);
        ResultMessage<KullaniciCevap> Update(KullaniciCevap data);
        ResultMessage<KullaniciCevap> SoftDelete(int id);
        ResultMessage<ICollection<KullaniciCevap>> GetAll(Expression<Func<KullaniciCevap, bool>> filter = null);
    }
}
