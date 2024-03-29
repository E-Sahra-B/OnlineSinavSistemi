﻿using Business.Abstract;
using Core.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class SinavSoruService: ISinavSoruService
    {
        ISinavSoruRepository repository;
        public SinavSoruService(ISinavSoruRepository _repository)
        {
            repository = _repository;
        }
        public ResultMessage<SinavSoru> Add(SinavSoru data)
        {
            return repository.Add(data);
        }
        public ResultMessage<ICollection<SinavSoru>> GetAll(Expression<Func<SinavSoru, bool>> filter = null)
        {
            return repository.GetAll(filter);
        }

        public ResultMessage<SinavSoru> SoftDelete(int id)
        {
            return repository.SoftDelete(id);
        }

        public ResultMessage<SinavSoru> Update(SinavSoru data)
        {
            return repository.Update(data);
        }
    }
}
