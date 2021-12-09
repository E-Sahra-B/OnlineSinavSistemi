using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Yonetici : Kullanici
    {
        public int YoneticiID { get; set; }
        public string YoneticiAdi { get; set; }
        public ICollection<Sinav> KaydedilenSinavlar { get; set; }
    }
}
