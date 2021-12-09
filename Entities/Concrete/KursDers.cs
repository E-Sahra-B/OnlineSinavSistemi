namespace Entities.Concrete
{
    public class KursDers : Base
    {
        public int KullaniciId { get; set; }
        public int DersId { get; set; }
        //navigation properties
        public Kullanici Kullanici { get; set; }
        public Ders Ders { get; set; }
    }
}
