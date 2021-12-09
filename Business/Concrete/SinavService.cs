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
    public class SinavService: ISinavService
    {
        ISinavRepository repository;
        public SinavService(ISinavRepository _repository)
        {
            repository = _repository;
        }
        public ResultMessage<Sinav> Add(Sinav data)
        {
            return repository.Add(data);
        }
        public ResultMessage<ICollection<Sinav>> GetAll(Expression<Func<Sinav, bool>> filter = null)
        {
            return repository.GetAll(filter);
        }

        public ResultMessage<Sinav> SoftDelete(int id)
        {
            return repository.SoftDelete(id);
        }

        public ResultMessage<Sinav> Update(Sinav data)
        {
            return repository.Update(data);
        }
    }
}
