using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ScheduleWebApp.Models;

namespace ScheduleWebApp.DatabaseConnection
{
    public class ScheduleDbContext : DbContext
    {
        public ScheduleDbContext(DbContextOptions<ScheduleDbContext> options)
    : base(options)
        {

        }
        public DbSet<ScheduleDateAndTime> ScheduleDateAndTimes { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
