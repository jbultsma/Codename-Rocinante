using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Rocinante.Models;

namespace Rocinante.Data
{
   
    public class ApplicationDbContext : IdentityDbContext
    {
        public static List<Job> jobList = new List<Job>();

        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Job> Job { get; set; }
    }
}