using Core.Entities;
using Microsoft.EntityFrameworkCore;
using BussinesLogic.Seeder;

namespace BussinesLogic.Data
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options) : base(options)
        {

        }

        //Añadir DBSets (las tablas de la base de datos)
        public DbSet<User>? Users { get; set; }
        public DbSet<Course>? Courses { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Student>? Students { get; set; }
        public DbSet<Core.Entities.Index>? Indexes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            DataSeeder.Seed(modelBuilder);
        }

    }
}
