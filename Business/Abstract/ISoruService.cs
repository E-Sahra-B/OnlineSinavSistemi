﻿using Core.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface ISoruService
    {
        ResultMessage<Soru> Add(Soru data);
        ResultMessage<Soru> Update(Soru data);
        ResultMessage<Soru> SoftDelete(int id);
        ResultMessage<ICollection<Soru>> GetAll(Expression<Func<Soru, bool>> filter = null);
    }
}
