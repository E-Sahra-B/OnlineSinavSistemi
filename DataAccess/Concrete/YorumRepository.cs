using Core.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete
{
    public class YorumRepository : EFBaseRepository<OnlineSinavSistemiContext, Yorum>, IYorumRepository
    {
        public YorumRepository(OnlineSinavSistemiContext context) : base(context)
        {
        }
        public List<Yorum> IciBosYorumlar()
        {
            return context.Yorum.Where(x => x.Aciklama == null).ToList();
        }
    }
}
