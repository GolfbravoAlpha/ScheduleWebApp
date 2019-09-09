using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ScheduleWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class staffHoursWorkedController : ControllerBase
    {
        // GET: api/staffHoursWorked
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/staffHoursWorked/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/staffHoursWorked
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/staffHoursWorked/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
