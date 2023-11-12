using System.ComponentModel.DataAnnotations;

namespace Petshop.Models
{
    public class User
    {
        [Required]
        public string Username { get; set; }

        [Required]

        public string Password { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string FullName { get; set; }

        public string Address { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }
    }
}
