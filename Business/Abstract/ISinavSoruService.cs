using Core.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface ISinavSoruService
    {
        ResultMessage<SinavSoru> Add(SinavSoru data);
        ResultMessage<SinavSoru> Update(SinavSoru data);
        ResultMessage<SinavSoru> SoftDelete(int id);
        ResultMessage<ICollection<SinavSoru>> GetAll(Expression<Func<SinavSoru, bool>> filter = null);
    }
}
