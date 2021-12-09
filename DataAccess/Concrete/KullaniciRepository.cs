using Core.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete
{
    public class KullaniciRepository : EFBaseRepository<OnlineSinavSistemiContext, Kullanici>, IKullaniciRepository
    {
        public KullaniciRepository(OnlineSinavSistemiContext context) : base(context)
        {
        }
        public List<Kullanici> KullaniciMailListesi()
        {
            return context.Kullanici.Where(x => x.EMail == null).ToList();
        }
    }
}
