using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Ogretmen : Kullanici
    {
        public int OgretmenId { get; set; }
        public string OgrenmenAdi { get; set; }

        public ICollection<Sinav> OgretmeniOlunanSinavlar { get; set; }
    }
}
