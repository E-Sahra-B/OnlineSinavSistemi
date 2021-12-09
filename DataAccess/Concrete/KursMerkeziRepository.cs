using Core.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete
{
    public class KursMerkeziRepository : EFBaseRepository<OnlineSinavSistemiContext, KursMerkezii>, IKursMerkeziRepository
    {
        public KursMerkeziRepository(OnlineSinavSistemiContext context) : base(context)
        {
        }
        public ICollection<KursMerkezii> IlceSec(string ilce)
        {
            return context.KursMerkezii.Where(x => x.Ilce == ilce).ToList();
        }
        public ICollection<KursMerkezii> IlSec(string il)
        {
            return context.KursMerkezii.Where(x => x.Il == il).ToList();
        }
    }
}
