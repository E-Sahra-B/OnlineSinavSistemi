using Core.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete
{
    public class RolRepository : EFBaseRepository<OnlineSinavSistemiContext, Rol>, IRolRepository
    {
        public RolRepository(OnlineSinavSistemiContext context) : base(context)
        {
        }
        public ICollection<Rol> RolleriGetir()
        {
            return context.Rol.Where(x => x.KullaniciRoller == null).ToList();
        }
    }
}
