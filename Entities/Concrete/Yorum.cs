using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    public class Yorum : Base
    {
        [ForeignKey("Ders")]
        public int DersId { get; set; }
        [ForeignKey("Kullanici")]
        public int KullaniciId { get; set; }
        public string Aciklama { get; set; }
        public virtual Ders Ders { get; set; }
        public virtual Kullanici Kullanici { get; set; }
    }
}
