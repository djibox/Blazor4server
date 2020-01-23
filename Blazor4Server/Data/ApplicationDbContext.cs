using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor4Server.Models;
using Microsoft.EntityFrameworkCore;

namespace Blazor4Server.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().HasData
                (
                new
                {
                    StudentId = Guid.NewGuid().ToString(),
                    Firstname="Leger",
                    Lastname="DJIBA",
                    School="CEMIS"
                },
                new
                {
                    StudentId = Guid.NewGuid().ToString(),
                    Firstname = "Jean Linux",
                    Lastname = "DJIBA",
                    School = "Havard"
                },
                new
                {
                    StudentId = Guid.NewGuid().ToString(),
                    Firstname = "Leger Junior",
                    Lastname = "DJIBA",
                    School = "Teluq"
                }
                );
        }
    }
}
