using Core.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete
{
    public class SoruRepository : EFBaseRepository<OnlineSinavSistemiContext, Soru>, ISoruRepository
    {
        public SoruRepository(OnlineSinavSistemiContext context) : base(context)
        {
        }
        public ICollection<Soru> BransSorulari(int bransSorulari)
        {
            return context.Soru.Where(x => x.BransId == bransSorulari).ToList();
        }
    }
}
