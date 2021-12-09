using System.ComponentModel.DataAnnotations;

namespace UI.Models
{
    public class LoginViewModel
    {
        [Required]
        public string EMail { get; set; }
        [Required]
        public string Sifre { get; set; }
    }

}
