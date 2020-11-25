using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Contact_API.Models
{
    public class Skill
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name cannot be null or empty")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Level cannot be null or empty")]
        public string Level { get; set; }

        public List<PersonnalSkill> PersonnalSkills { get; set; }
    }
}
