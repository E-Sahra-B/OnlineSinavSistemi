using Core.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IDersService
    {
        ResultMessage<Ders> Add(Ders data);
        ResultMessage<Ders> Update(Ders data);
        ResultMessage<Ders> SoftDelete(int id);
        ResultMessage<ICollection<Ders>> GetAll(Expression<Func<Ders, bool>> filter = null);
    }
}
