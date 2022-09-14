using Core.Entities;
using Microsoft.EntityFrameworkCore;
namespace BussinesLogic.Seeder
{
    public class DataSeeder
    {
        static public void Seed(ModelBuilder modelBuilder)
        {
            DateTime creationDate = DateTime.Now;

            modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 1,
                Name = "Andrés",
                LastName = "Sainz",
                Email = "andresain@gmail.com",
                Password = "saiaie88721",
                CreatedBy = "Seeder",
                CreatedAt = creationDate,
                IsDeleted = false,
            },
            new User
            {
                Id = 2,
                Name = "Chritian",
                LastName = "Lopez",
                Email = "lopez_ch@gmail.com",
                Password = "lopse399al",
                CreatedBy = "Seeder",
                CreatedAt = creationDate,
                IsDeleted = false,
            },
            new User
            {
                Id = 3,
                Name = "Marc",
                LastName = "Ruiz",
                Email = "marrruiz@gmail.com",
                Password = "ruimaer438",
                CreatedBy = "Seeder",
                CreatedAt = creationDate,
                IsDeleted = false,
            }
            );


            modelBuilder.Entity<Student>().HasData(
            new Student
            {
                Id = 1,
                Name = "Andrés",
                LastName = "Sainz",
                Birthay = new DateTime(1990, 2, 9),
                CreatedBy = "Seeder",
                CreatedAt = creationDate,
                IsDeleted = false,
                UserId = 1
            },
            new Student
            {
                Id = 2,
                Name = "Chritian",
                LastName = "Lopez",
                Birthay = new DateTime(1992, 6, 22),
                CreatedBy = "Seeder",
                CreatedAt = creationDate,
                IsDeleted = false,
                UserId = 2
            },
            new Student
            {
                Id = 3,
                Name = "Marc",
                LastName = "Ruiz",
                Birthay = new DateTime(1990, 1, 7),
                CreatedBy = "Seeder",
                CreatedAt = creationDate,
                IsDeleted = false,
                UserId = 3
            }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Frontend",
                    CreatedBy = "Seeder",
                    CreatedAt = creationDate
                },
                new Category
                {
                    Id = 2,
                    Name = "Backend",
                    CreatedBy = "Seeder",
                    CreatedAt = creationDate
                },
                new Category
                {
                    Id = 3,
                    Name = "Framework",
                    CreatedBy = "Seeder",
                    CreatedAt = creationDate
                },
                new Category
                {
                    Id = 4,
                    Name = "Testing",
                    CreatedBy = "Seeder",
                    CreatedAt = creationDate
                },
                new Category
                {
                    Id = 5,
                    Name = "Movile",
                    CreatedBy = "Seeder",
                    CreatedAt = creationDate
                }
                );

            modelBuilder.Entity<Course>().HasData(
            new Course
            {
                Id = 1,
                Name = "Javascript Básico",
                ShortDescription = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore",
                LongDescription = "Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur?",
                Level = Levels.Basic,
                CreatedBy = "Seeder",
                CreatedAt = creationDate

            },
            new Course
            {
                Id = 2,
                Name = "Javascript Avanzado",
                ShortDescription = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore",
                LongDescription = "Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur?",
                Level = Levels.Advanced,
                CreatedBy = "Seeder",
                CreatedAt = creationDate
            },
            new Course
            {
                Id = 3,
                Name = "PHP",
                ShortDescription = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore",
                LongDescription = "Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur?",
                Level = Levels.Medium,
                CreatedBy = "Seeder",
                CreatedAt = creationDate
            });
            modelBuilder.Entity<Core.Entities.Index>().HasData(
                new Core.Entities.Index
                {
                    Id = 1,
                    List = "Index Javascript Básico",
                    CourseId = 1
                },
                new Core.Entities.Index
                {
                    Id = 2,
                    List = "Index Javascript Avanzado",
                    CourseId = 2
                },
                new Core.Entities.Index
                {
                    Id = 3,
                    List = "Index PHP",
                    CourseId = 3
                });

           //Many to many relations tables seeders
           modelBuilder
            .Entity<Course>()
            .HasMany(c => c.Categories)
            .WithMany(c => c.Courses)
            .UsingEntity(j => j.HasData(
                new { CoursesId = 1, CategoriesId = 1 },
                new { CoursesId = 2, CategoriesId = 3 },
                new { CoursesId = 3, CategoriesId = 2 }
                ));

            modelBuilder
            .Entity<Student>()
            .HasMany(s => s.Courses)
            .WithMany(s => s.Students)
            .UsingEntity(j => j.HasData(
                new { StudentsId = 1, CoursesId = 1 },
                new { StudentsId = 1, CoursesId = 2 },
                new { StudentsId = 1, CoursesId = 3 },
                new { StudentsId = 2, CoursesId = 1 },
                new { StudentsId = 2, CoursesId = 2 }
                ));




        }
    }
}
