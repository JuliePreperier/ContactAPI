using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Contact_API.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name cannot be null or empty")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email cannot be null or empty")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password cannot be null or empty")]
        public string Password { get; set; }

        public string Role { get; set; }
    }
}
