using Microsoft.EntityFrameworkCore;
using UniversityApiBE.Models.DataModels;

namespace UniversityApiBE.DataAcces
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
        public DbSet<Student>? Students { get; set;}
        public DbSet<UniversityApiBE.Models.DataModels.Index>? Indexes { get; set; }
    }
}
