using Microsoft.EntityFrameworkCore;
using BlazorAppProject.Data;

namespace BlazorAppProject.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        public DbSet<AddmissionStudents> Students { get; set; }

        public async Task AddStudentAsync(AddmissionStudents student)
        {
            Students.Add(student);
            await SaveChangesAsync();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AddmissionStudents>()
                .HasIndex(s => s.Email)
                .IsUnique();

            // Add other configurations as needed

            base.OnModelCreating(modelBuilder);
        }
    }
}
