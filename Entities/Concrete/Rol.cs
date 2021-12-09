using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Rol : Base
    {
        public string Ad { get; set; }
        public virtual ICollection<KullaniciRol> KullaniciRoller { get; set; }
    }
}
