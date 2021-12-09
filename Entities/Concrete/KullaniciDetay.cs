using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    public class KullaniciDetay : Base
    {
        [ForeignKey("Kullanici")]
        public int KullaniciId { get; set; }
        public string Mezuniyet { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public virtual Kullanici Kullanici { get; set; }
    }
}
