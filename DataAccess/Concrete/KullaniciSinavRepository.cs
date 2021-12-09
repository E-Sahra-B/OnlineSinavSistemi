using Core.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete
{
    public class KullaniciSinavRepository : EFBaseRepository<OnlineSinavSistemiContext, KullaniciSinav>, IKullaniciSinavRepository
    {
        public KullaniciSinavRepository(OnlineSinavSistemiContext context) : base(context)
        {
        }
        public ICollection<KullaniciSinav> KullaniciSinavlariGetir(int id)
        {
            return context.KullaniciSinav.Where(x => x.SinavId == id).ToList();
        }
    }
}
