using System.ComponentModel.DataAnnotations;

namespace Veterinary.Common.Models
{
    public class EmailRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
