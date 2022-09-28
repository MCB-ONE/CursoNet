using Core.Entities;
using Microsoft.EntityFrameworkCore;
using BussinesLogic.Seeder;
using Microsoft.Extensions.Logging;

namespace BussinesLogic.Data
{
    public class UniversityDBContext : DbContext
    {
        private readonly ILoggerFactory _loggerFactory;

        public UniversityDBContext(DbContextOptions<UniversityDBContext> options, ILoggerFactory loggerFactory) : base(options)
        {
            _loggerFactory = loggerFactory;
        }

        //Añadir DBSets (las tablas de la base de datos)
        public DbSet<User>? Users { get; set; }
        public DbSet<Course>? Courses { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Student>? Students { get; set; }
        public DbSet<Core.Entities.Index>? Indexes { get; set; }

        // Configurar logger en el contexto
        // Permite generar loggs cuando se interactue con el contexto (operaciones CRUD)
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var logger = _loggerFactory.CreateLogger<UniversityDBContext>();

            // Especificamos el nivel de logs y donde guardarlos
            //optionsBuilder.LogTo(d => logger.Log(LogLevel.Information, d, new[] { DbLoggerCategory.Database.Name })); // Con esta config se egistrarían todas las interacciones con la base de datos (demasiada información)
            //optionsBuilder.EnableSensitiveDataLogging(); // Habilitar registrar datos "sensibles" en los mensajes de log

            // Personalizamos y seleccionamos solo aquellas operaciones que queremos registrar
            // Filtramos los logs que seran de nivel informativo y si hay error que sea lo mas detallado posible
            optionsBuilder.LogTo(d => logger.Log(LogLevel.Information, d, new[] { DbLoggerCategory.Database.Name }), LogLevel.Information)
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email).IsUnique();

            DataSeeder.Seed(modelBuilder);
        }

    }
}
