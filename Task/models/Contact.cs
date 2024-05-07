using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [MaxLength(15, ErrorMessage = "First name cannot exceed 15 characters.")]
        public string firstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [MaxLength(15, ErrorMessage = "Last name cannot exceed 15 characters.")]
        public string lastName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string email { get; set; }

        [Phone(ErrorMessage = "Phone number must only contain numbers")]
        [StringLength(10,MinimumLength =10, ErrorMessage = "Phone number must be exactly 10 digits long.")]
        public string phoneNumber { get; set; }
      
    }

}
