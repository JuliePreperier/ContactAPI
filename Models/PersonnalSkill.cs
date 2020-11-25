using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Contact_API.Models
{
    public class PersonnalSkill
    {
        public int PersonId { get; set; }
        [JsonIgnore]
        public Person Person { get; set; }
        public int SkillId { get; set; }
        [JsonIgnore]
        public Skill Skill { get; set; }
    }
}
