using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScheduleWebApp.Data;
using ScheduleWebApp.Models;

namespace ScheduleWebApp.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleDateAndTimeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ScheduleDateAndTimeController(ApplicationDbContext context)
        {
            this._context = context;
        }

        // GET: api/ScheduleDateAndTime
        [HttpGet]
        public IEnumerable<ScheduleDateAndTime> GetScheduleDateAndTime()
        {
            //the include allows information from another table to come through 
            return _context.ScheduleDateAndTimes
                .Include(c => c.student)
                .Include(c => c.staff)
                .ToList();
        }

        // GET: api/ScheduleDateAndTime/5
        [HttpGet("{id}", Name = "Get")]
        public string GetScheduleDateAndTime(int id)
        {
            return "value";
        }

        //POST: api/ScheduleDateAndTime
        [HttpPost]
        public async Task<ActionResult<ScheduleDateAndTime>> PostScheduleDateAndTime
            (ScheduleDateAndTime scheduleObject)
        {
            _context.ScheduleDateAndTimes.Add(scheduleObject);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetScheduleDateAndTime),
                new { id = scheduleObject.id }, scheduleObject);
            //return Ok(scheduleObject);
        }

        // PUT: api/ScheduleDateAndTime/5
        [HttpPut("{id}")]
        public void PutScheduleDateAndTime(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void DeleteScheduleDateAndTime(int id)
        {
        }
    }
}
