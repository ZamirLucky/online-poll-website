using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required(ErrorMessage = "The username is required.")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "The username must be between 5 and 50 characters long.")]
        [RegularExpression(@"^[a-zA-Z0-9_\-]+$", ErrorMessage = "The username can only contain letters, numbers, underscores, and hyphens.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "The password is required.")]
        [MaxLength(8, ErrorMessage = "The password cannot exceed 8 characters.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$", ErrorMessage = "The password must contain at least one uppercase letter, one lowercase letter, and one number.")]
        public string PasswordHash { get; set; }
        public DateTime DateRegistered { get; set; }
    }
}
