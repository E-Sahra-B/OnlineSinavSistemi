using Core.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete
{
    public class BransRepository : EFBaseRepository<OnlineSinavSistemiContext, Brans>, IBransRepository
    {
        public BransRepository(OnlineSinavSistemiContext context) : base(context)
        {
        }
        public ICollection<Brans> AnaBranslariGetir()
        {
            return context.Brans.Where(x => x.UstBransId == null).ToList();
        }
    }
}
