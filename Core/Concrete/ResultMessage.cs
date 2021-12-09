using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Concrete
{
    public class ResultMessage<T>
    {
        public bool BasariliMi { get; set; }
        public string Mesaj { get; set; }
        public T Data { get; set; }
    }
}
