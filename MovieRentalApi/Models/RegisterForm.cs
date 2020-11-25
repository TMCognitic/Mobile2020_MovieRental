using System.ComponentModel.DataAnnotations;

namespace MovieRentalApi.Models
{
    public class RegisterForm
    {
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string LastName { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(320)]
        public string Email { get; set; }
        [Required]
        [MaxLength(20)]
        public string Passwd { get; set; }
    }
}
