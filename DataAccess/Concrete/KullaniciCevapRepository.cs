using Core.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete
{
    public class KullaniciCevapRepository : EFBaseRepository<OnlineSinavSistemiContext, KullaniciCevap>, IKullaniciCevapRepository
    {
        public KullaniciCevapRepository(OnlineSinavSistemiContext context) : base(context)
        {
        }
        public List<KullaniciCevap> KullaniciCevaplari()
        {
            return context.KullaniciCevap.Where(x => x.SoruId == 0).ToList();
        }
    }
}
