using Core.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IKursMerkeziService
    {
        ResultMessage<KursMerkezii> Add(KursMerkezii data);
        ResultMessage<KursMerkezii> Update(KursMerkezii data);
        ResultMessage<KursMerkezii> SoftDelete(int id);
        ResultMessage<ICollection<KursMerkezii>> GetAll(Expression<Func<KursMerkezii, bool>> filter = null);
    }
}
