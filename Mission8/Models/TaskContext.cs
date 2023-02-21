using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission8.Models
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base (options)
        {
            // leave blank for now
        }
        public DbSet<TaskFormResponse> responses { get; set; }
        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Home"}, 
                new Category { CategoryID = 2, CategoryName = "School"},
                new Category { CategoryID = 3, CategoryName = "Work"},
                new Category { CategoryID = 4, CategoryName  = "Church"}
                );
            mb.Entity<TaskFormResponse>().HasData(

                new TaskFormResponse
                {
                    TaskID = 1,
                    TaskName = "Study for 404 midterm",
                    CategoryID = "2",
                    Completed = false,
                    Quadrant = 1
                },
                new TaskFormResponse
                {
                    TaskID = 2,
                    TaskName = "Mission 8 Assignment",
                    CategoryID = "2",
                    Completed = false,
                    Quadrant = 2
                },
                new TaskFormResponse
                {
                    TaskID = 3,
                    TaskName = "Call Mom",
                    CategoryID = "1",
                    Completed = false,
                    Quadrant = 3
                },
                new TaskFormResponse
                {
                    TaskID = 4,
                    TaskName = "Therapy",
                    CategoryID = "1",
                    Completed = false,
                    Quadrant = 4
                }

                );
        }
    }
}
