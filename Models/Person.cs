using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Contact_API.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Firstname cannot be null or empty")]
        public string Firstname { get; set; }
        [Required(ErrorMessage = "Lastname cannot be null or empty")]
        public string Lastname { get; set; }
        [Required(ErrorMessage = "Fullname cannot be null or empty")]
        public string Fullname { get; set; }
        [Required(ErrorMessage = "Address cannot be null or empty")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Email cannot be null or empty")]
        [EmailAddress(ErrorMessage = "Email has to be an email adress")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Firstname cannot be null or empty")]
        [Phone(ErrorMessage = "PhoneNumber has to be a mobile phone number")]
        public string PhoneNumber { get; set; }

        public List<PersonnalSkill> PersonnalSkills { get; set; }
    }
}
