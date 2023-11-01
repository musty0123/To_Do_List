using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using To_Do_List.Models.Entity;

namespace To_Do_List.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<TaskWrapper> tasks { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskWrapper>().HasData(
                new TaskWrapper
                {
                    Id = 1,
                    task = "Do the laundry",
                    RecievedTime = DateTime.Now,
                    DueDate = DateTime.Now.AddDays(30),
                    IsCompleted = false


                },
                new TaskWrapper
                {
                    Id = 2,
                    task = "Watch all episodes of One Piece",
                    RecievedTime = DateTime.Now,
                    DueDate = DateTime.Now.AddDays(7),
                    IsCompleted = false
                }

                );
        }



    }
}
