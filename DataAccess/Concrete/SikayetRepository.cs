using Core.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete
{
    public class SikayetRepository : EFBaseRepository<OnlineSinavSistemiContext, Sikayet>, ISikayetRepository
    {
        public SikayetRepository(OnlineSinavSistemiContext context) : base(context)
        {
        }
        public ICollection<Sikayet> DersinSikayetleriniGetir(int dersid, int kullaniciid)
        {
            return context.Sikayet.Where(x => x.KullaniciId == kullaniciid).Where(d => d.DersId == dersid).ToList();
        }
        public ICollection<Sikayet> SikayetleriGetir(int kullaniciid)
        {
            return context.Sikayet.Where(x => x.KullaniciId == kullaniciid).ToList();
        }
    }
}
