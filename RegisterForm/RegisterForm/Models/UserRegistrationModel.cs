using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterForm.Models
{
    public class UserRegistrationModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Please Enter Your Full Name")]
        [Display(Name ="User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Please Enter Email")]
        [Display(Name ="Email")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Please Enter Your Phone Number")]
        [Display(Name ="Mobile Phone")]
        public string PhoneNumber { get; set; }

        public string City { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Enter Password")]
        public string Password { get; set; }
    }
}
