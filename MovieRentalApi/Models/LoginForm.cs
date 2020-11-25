using System.ComponentModel.DataAnnotations;

namespace MovieRentalApi.Models
{
    public class LoginForm
    {
        [Required]
        [MaxLength(320)]
        public string Email { get; set; }
        [Required]
        [MaxLength(20)]
        public string Passwd { get; set; }
    }
}
