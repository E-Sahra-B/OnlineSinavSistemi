namespace Entities.Concrete
{
    public class SinavSoru : Base
    {
        public int SinavId { get; set; }
        public int SoruId { get; set; }
        public Sinav Sinav { get; set; }
        public Soru Soru { get; set; }
    }
}
