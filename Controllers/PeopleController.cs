using Contact_API.Data;
using Contact_API.Models;
using Microsoft.AspNetCore.Authorization;
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
    public class PeopleController : ControllerBase
    {
        private ContactDbContext _dbContext;

        public PeopleController(ContactDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        // GET: api/<PeopleController>
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return _dbContext.People.Include(p =>p.PersonnalSkills);
        }

        /*
         * Swagger already return status Code, I didn't find useful to use IActionResult in this exercise
         * 
         * public IActionResult Get()
         * {
         *       return Ok(_dbContext.People);
         * }
         */

        // GET api/<PeopleController>/5
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            var person = _dbContext.People
                                    .Include(p => p.PersonnalSkills)
                                    .FirstOrDefault(p => p.Id == id);
            return person;
        }

        // POST api/<PeopleController>
        [HttpPost]
        public void Post([FromBody] Person person)
        {
            _dbContext.People.Add(person);
            _dbContext.SaveChanges();
        }

        // PUT api/<PeopleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Person person)
        {
            var pers = _dbContext.People.Find(id);

            pers.Firstname = person.Firstname;
            pers.Lastname = person.Lastname;
            pers.Fullname = person.Fullname;
            pers.Address = person.Address;
            pers.Email = person.Email;
            pers.PhoneNumber = person.PhoneNumber;

            _dbContext.SaveChanges();

        }

        // DELETE api/<PeopleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var person = _dbContext.People.Find(id);
            _dbContext.People.Remove(person);

            _dbContext.SaveChanges();
        }
    }
}
