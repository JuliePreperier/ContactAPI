using Contact_API.Data;
using Contact_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Contact_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        private ContactDbContext _dbContext;

        public SkillsController(ContactDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        // GET: api/<SkillsController>
        [HttpGet]
        public IEnumerable<Skill> Get()
        {
            return _dbContext.Skills.Include(s => s.PersonnalSkills);
        }


        // GET api/<SkillsController>/5
        [HttpGet("{id}")]
        public Skill Get(int id)
        {
            var skill = _dbContext.Skills
                                    .Include(s => s.PersonnalSkills)
                                    .FirstOrDefault(s => s.Id == id);
            return skill;
        }

        // POST api/<SkillsController>
        [HttpPost]
        public void Post([FromBody] Skill skill)
        {
            _dbContext.Skills.Add(skill);
            _dbContext.SaveChanges();
        }

        // PUT api/<SkillsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Skill skill)
        {
            var sk = _dbContext.Skills.Find(id);

            sk.Name = skill.Name;
            sk.Level = skill.Level;

            _dbContext.SaveChanges();

        }

        // DELETE api/<SkillsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var skill = _dbContext.Skills.Find(id);
            _dbContext.Skills.Remove(skill);

            _dbContext.SaveChanges();
        }
    }
}
