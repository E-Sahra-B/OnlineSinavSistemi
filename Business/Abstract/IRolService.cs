using Core.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IRolService
    {
        ResultMessage<Rol> Add(Rol data);
        ResultMessage<Rol> Update(Rol data);
        ResultMessage<Rol> SoftDelete(int id);
        ResultMessage<ICollection<Rol>> GetAll(Expression<Func<Rol, bool>> filter = null);
    }
}
