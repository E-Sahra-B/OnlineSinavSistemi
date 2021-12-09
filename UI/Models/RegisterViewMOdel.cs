using System;
using System.ComponentModel.DataAnnotations;

namespace UI.Models
{
    public class RegisterViewModel
    {
        [Required]
        public string Ad { get; set; }
        [Required]
        public string Soyad { get; set; }
        [Required]
        public int Tc { get; set; }
        public DateTime DogumTarihi { get; set; }
        [Required]
        public string EMail { get; set; }
        [Required]
        public string Sifre { get; set; }
        public string FotoURL { get; set; }
        public string Discriminator { get; set; }
    }
}
