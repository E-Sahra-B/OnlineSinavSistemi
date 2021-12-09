using Core.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface ISinavService
    {
        ResultMessage<Sinav> Add(Sinav data);
        ResultMessage<Sinav> Update(Sinav data);
        ResultMessage<Sinav> SoftDelete(int id);
        ResultMessage<ICollection<Sinav>> GetAll(Expression<Func<Sinav, bool>> filter = null);
    }
}
