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

        //public ApplicationDbContext()
        //{
        //    DbContextOptionsBuilder optionsBuilder= new DbContextOptionsBuilder();
        //    optionsBuilder.UseSqlServer(@"Server=DESKTOP-95NNO4H\\SQLEXPRESS;Database=Rocinante;");
        //}

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Job> Job { get; set; }
        public DbSet<Activity> Activity { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=DESKTOP-95NNO4H\\SQLEXPRESS;Database=Rocinante;");
        //}
    }
}