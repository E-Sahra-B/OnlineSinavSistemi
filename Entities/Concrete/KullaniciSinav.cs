using System.Collections.Generic;

namespace Entities.Concrete
{
    public class KullaniciSinav : Base
    {
        public int KullaniciId { get; set; }
        public int SinavId { get; set; }
        public bool SinavBittiMi { get; set; }
        public Kullanici Kullanici { get; set; }
        public Sinav Sinav { get; set; }
        public ICollection<KullaniciCevap> KullaniciSinavCevaplari { get; set; }
    }
}
