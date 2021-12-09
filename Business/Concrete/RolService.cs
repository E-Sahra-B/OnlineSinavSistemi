using Business.Abstract;
using Core.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class RolService: IRolService
    {
        IRolRepository repository;
        public RolService(IRolRepository _repository)
        {
            repository = _repository;
        }
        public ResultMessage<Rol> Add(Rol data)
        {
            return repository.Add(data);
        }
        public ResultMessage<ICollection<Rol>> GetAll(Expression<Func<Rol, bool>> filter = null)
        {
            return repository.GetAll(filter);
        }

        public ResultMessage<Rol> SoftDelete(int id)
        {
            return repository.SoftDelete(id);
        }

        public ResultMessage<Rol> Update(Rol data)
        {
            return repository.Update(data);
        }
    }
}
