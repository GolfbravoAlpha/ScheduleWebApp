using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ScheduleWebApp.Models;

namespace ScheduleWebApp.Data
{

    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<ScheduleDateAndTime> ScheduleDateAndTimes { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Student> Students { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

    }
}
