using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using МојТермин.Models;

namespace МојТермин.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<МојТермин.Models.Doctor> Doctor { get; set; }
        public DbSet<МојТермин.Models.Patient> Patient { get; set; }
    }
}
