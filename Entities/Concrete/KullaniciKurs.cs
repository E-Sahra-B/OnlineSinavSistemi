using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    public class KullaniciKurs : Base
    {
        [ForeignKey("Kurs")]
        public int KursId { get; set; }
        [ForeignKey("Kullanici")]
        public int KullaniciId { get; set; }
        public string Durum { get; set; }
        public virtual Kurs Kurs { get; set; }
        public virtual Kullanici Kullanici { get; set; }
    }
}
