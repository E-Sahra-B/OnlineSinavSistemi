using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    public class Ders : Base
    {
        [ForeignKey("Kurs")]
        public int KursId { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public string VideoUrl { get; set; }
        public string DokumanUrl { get; set; }
        public virtual Kurs Kurs { get; set; }
        public virtual ICollection<KursDers> KullanicininDersleri { get; set; }
    }
}
