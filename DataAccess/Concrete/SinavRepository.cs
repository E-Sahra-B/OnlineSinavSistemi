using Core.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete
{
    public class SinavRepository : EFBaseRepository<OnlineSinavSistemiContext, Sinav>, ISinavRepository
    {
        public SinavRepository(OnlineSinavSistemiContext context) : base(context)
        {
        }
        List<Sinav> ISinavRepository.KontejyanaBak()
        {
            return context.Sinav.Where(x => x.Kontenjan == null).ToList();
        }
    }
}
