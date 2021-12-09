namespace Entities.Concrete
{
    public class KullaniciRol : Base
    {
        public int KullaniciId { get; set; }
        public int RolId { get; set; }
        public Kullanici Kullanici { get; set; }
        public Rol Rol { get; set; }
    }
}
