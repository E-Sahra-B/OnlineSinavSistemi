using Core.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete
{
    public class KursDersRepository : EFBaseRepository<OnlineSinavSistemiContext, KursDers>, IKursDersRepository
    {
        public KursDersRepository(OnlineSinavSistemiContext context) : base(context)
        {
        }
        public ICollection<Ders> KursunDersleriniGetir(int id)
        {
            return context.Ders.Where(x => x.KursId == id).ToList();
        }
        public ICollection<Kullanici> KursunKullanicilariniGetir(int id)
        {
            return context.KullaniciKurs.Where(x => x.KursId == id).Select(x => x.Kullanici).ToList();
        }
    }
}
