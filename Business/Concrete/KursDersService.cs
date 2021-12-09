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
    public class KursDersService: IKursDersService
    {
        IKursDersRepository repository;
        public KursDersService(IKursDersRepository _repository)
        {
            repository = _repository;
        }
        public ResultMessage<KursDers> Add(KursDers data)
        {
            return repository.Add(data);
        }
        public ResultMessage<ICollection<KursDers>> GetAll(Expression<Func<KursDers, bool>> filter = null)
        {
            return repository.GetAll(filter);
        }

        public ResultMessage<KursDers> SoftDelete(int id)
        {
            return repository.SoftDelete(id);
        }

        public ResultMessage<KursDers> Update(KursDers data)
        {
            return repository.Update(data);
        }
    }
}
