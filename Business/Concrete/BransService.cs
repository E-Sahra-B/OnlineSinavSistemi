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
    public class BransService : IBransService
    {
        IBransRepository repository;
        public BransService(IBransRepository _repository)
        {
            repository = _repository;
        }
        public ResultMessage<Brans> Add(Brans data)
        {
          return  repository.Add(data);
        }
        public ResultMessage<ICollection<Brans>> GetAll(Expression<Func<Brans, bool>> filter = null)
        {
            return repository.GetAll(filter);
        }
        public ResultMessage<Brans> SoftDelete(int id)
        {
            return repository.SoftDelete(id);
        }
        public ResultMessage<Brans> Update(Brans data)
        {
            return repository.Update(data);
        }
    }
}
