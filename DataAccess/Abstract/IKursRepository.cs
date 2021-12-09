using Core.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IKursRepository : IRepository<Kurs>
    {
        DateTime KursunBaslamaTarihiniOgren(int KursId);
        ICollection<Kurs> GetCoursesWithExams();
    }
}
