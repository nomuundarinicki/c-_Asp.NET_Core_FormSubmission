using System.ComponentModel.DataAnnotations;

namespace YourNamespace.Models
{
    public class User : BaseEntity
    {
        [Required]
        [MinLength(3)]
        public string FirstName { get; set; }
        [Required]
        [MinLength(3)]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public int Age { get; set; }
        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
    public abstract class BaseEntity {}
    
}