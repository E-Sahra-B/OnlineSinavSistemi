using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    public class KullaniciCevap : Base
    {
        [ForeignKey("KullaniciSinav")]
        public int KullaniciSinavId { get; set; }
        [ForeignKey("Soru")]
        public int SoruId { get; set; }
        public char Cevap { get; set; }
        public virtual KullaniciSinav KullaniciSinav { get; set; }
        public virtual Soru Soru { get; set; }
    }
}