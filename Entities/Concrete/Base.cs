using Core.Abstract;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Base : IVeri
    {
        [Key]
        public int Id { get; set; }
        public bool SilindiMi { get; set; }
        public DateTime KayitTarihi { get; set; }
        //public Nullable<DateTime> GuncellemeTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
    }
}