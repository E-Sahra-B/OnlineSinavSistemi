using Core.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete
{
    public class DersRepository : EFBaseRepository<OnlineSinavSistemiContext, Ders>, IDersRepository
    {
        public DersRepository(OnlineSinavSistemiContext context) : base(context)
        {
        }
        public ICollection<Ders> DersleriGetir()
        {
            return context.Ders.Where(x => x.KullanicininDersleri == null).ToList();
        }
    }
}
