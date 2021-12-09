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
    public class KullaniciSinavService: IKullaniciSinavService
    {
        IKullaniciSinavRepository repository;
        public KullaniciSinavService(IKullaniciSinavRepository _repository)
        {
            repository = _repository;
        }
        public ResultMessage<KullaniciSinav> Add(KullaniciSinav data)
        {
            return repository.Add(data);
        }
        public ResultMessage<ICollection<KullaniciSinav>> GetAll(Expression<Func<KullaniciSinav, bool>> filter = null)
        {
            return repository.GetAll(filter);
        }

        public ResultMessage<KullaniciSinav> SoftDelete(int id)
        {
            return repository.SoftDelete(id);
        }

        public ResultMessage<KullaniciSinav> Update(KullaniciSinav data)
        {
            return repository.Update(data);
        }
    }
}
