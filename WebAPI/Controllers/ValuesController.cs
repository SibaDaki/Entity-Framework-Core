using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        public CVContext _db { get; set; }

        public ValuesController(CVContext database)
        {
            _db = database;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            Person person = new Person()
            {
                firstName = "Siba",
                lastName = "Daki",
                idNumber = 891109,
                dateOfBirth = DateTime.Now,
                cell = 12345,
                tel = 54321,
                addressLine1 = "Daki St",
                addressLine2 = "Sibaville",
                gender = "Female",
                email = "dakycyb@gmail.com"
            };

            //_db.people.InsertOnSubmit(person);
            _db.people.Add(person);
            _db.SaveChanges();
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
