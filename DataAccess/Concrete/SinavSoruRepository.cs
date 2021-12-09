using Core.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace DataAccess.Concrete
{
    public class SinavSoruRepository : EFBaseRepository<OnlineSinavSistemiContext, SinavSoru>, ISinavSoruRepository
    {
        public SinavSoruRepository(OnlineSinavSistemiContext context) : base(context)
        {
        }
        public ICollection<SinavSoru> SinavinSorularini(int soruId)
        {
            return GetAll(x => x.Id == soruId).Data;
        }
        public ICollection<SinavSoru> SorularinSinavlari(int sinavId)
        {
            return GetAll(x => x.Id == sinavId).Data;
            //using (OnlineSinavSistemiContext context = new OnlineSinavSistemiContext())
            // {
            //     return context.Sinav.Where(x => x.Id == sinavId).ToList();
            //}
        }
    }
}
