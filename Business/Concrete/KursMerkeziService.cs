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
    public class KursMerkeziService: IKursMerkeziService
    {
        IKursMerkeziRepository repository;
        public KursMerkeziService(IKursMerkeziRepository _repository)
        {
            repository = _repository;
        }
        public ResultMessage<KursMerkezii> Add(KursMerkezii data)
        {
            return repository.Add(data);
        }
        public ResultMessage<ICollection<KursMerkezii>> GetAll(Expression<Func<KursMerkezii, bool>> filter = null)
        {
            return repository.GetAll(filter);
        }

        public ResultMessage<KursMerkezii> SoftDelete(int id)
        {
            return repository.SoftDelete(id);
        }

        public ResultMessage<KursMerkezii> Update(KursMerkezii data)
        {
            return repository.Update(data);
        }
    }
}
