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
    public class KullaniciCevapService: IKullaniciCevapService
    {
        IKullaniciCevapRepository repository;
        public KullaniciCevapService(IKullaniciCevapRepository _repository)
        {
            repository = _repository;
        }
        public ResultMessage<KullaniciCevap> Add(KullaniciCevap data)
        {
            return repository.Add(data);
        }
        public ResultMessage<ICollection<KullaniciCevap>> GetAll(Expression<Func<KullaniciCevap, bool>> filter = null)
        {
            return repository.GetAll(filter);
        }

        public ResultMessage<KullaniciCevap> SoftDelete(int id)
        {
            return repository.SoftDelete(id);
        }

        public ResultMessage<KullaniciCevap> Update(KullaniciCevap data)
        {
            return repository.Update(data);
        }
    }
}
