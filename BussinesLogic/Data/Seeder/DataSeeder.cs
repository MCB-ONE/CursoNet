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
                Rol = Roles.User,
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
                Rol = Roles.User,
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
                Rol = Roles.User,
                CreatedBy = "Seeder",
                CreatedAt = creationDate,
                IsDeleted = false,
            },
            new User
            {
                Id = 4,
                Name = "Test Admin",
                LastName = "Test",
                Email = "admin@gmail.com",
                Password = "admin1234",
                Rol = Roles.Admin,
                CreatedBy = "Seeder",
                CreatedAt = creationDate,
                IsDeleted = false,
            },
            new User
            {
                Id = 5,
                Name = "Nicolas",
                LastName = "Cruz",
                Email = "nico@gmail.com",
                Password = "nicola3847",
                Rol = Roles.User,
                CreatedBy = "Seeder",
                CreatedAt = creationDate,
                IsDeleted = false,
            },
            new User
            {
                Id = 6,
                Name = "María",
                LastName = "Times",
                Email = "mtimes@gmail.com",
                Password = "73992hdj",
                Rol = Roles.User,
                CreatedBy = "Seeder",
                CreatedAt = creationDate,
                IsDeleted = false,
            },
            new User
            {
                Id = 7,
                Name = "Neri",
                LastName = "Lopez",
                Email = "nerilop@gmail.com",
                Password = "jooat528j",
                Rol = Roles.User,
                CreatedBy = "Seeder",
                CreatedAt = creationDate,
                IsDeleted = false,
            },
            new User
            {
                Id = 8,
                Name = "Pepe",
                LastName = "Vizio",
                Email = "vizipep@gmail.com",
                Password = "vizip3883",
                Rol = Roles.User,
                CreatedBy = "Seeder",
                CreatedAt = creationDate,
                IsDeleted = false,
            },
            new User
            {
                Id = 9,
                Name = "Carlos",
                LastName = "Domingo",
                Email = "domica13@gmail.com",
                Password = "1313dom12",
                Rol = Roles.User,
                CreatedBy = "Seeder",
                CreatedAt = creationDate,
                IsDeleted = false,
            },
            new User
            {
                Id = 10,
                Name = "Nieves",
                LastName = "Montaña",
                Email = "monieve@gmail.com",
                Password = "moni525niev",
                Rol = Roles.User,
                CreatedBy = "Seeder",
                CreatedAt = creationDate,
                IsDeleted = false,
            },
            new User
            {
                Id = 11,
                Name = "Mario",
                LastName = "Sainz",
                Email = "msainz@gmail.com",
                Password = "sain28282",
                Rol = Roles.User,
                CreatedBy = "Seeder",
                CreatedAt = creationDate,
                IsDeleted = false,
            },
            new User
            {
                Id = 12,
                Name = "Chritian",
                LastName = "Marco",
                Email = "m_chris@gmail.com",
                Password = "cmr8721",
                Rol = Roles.User,
                CreatedBy = "Seeder",
                CreatedAt = creationDate,
                IsDeleted = false,
            },
            new User
            {
                Id = 13,
                Name = "Lucas",
                LastName = "Ruiz",
                Email = "lucaruiz@gmail.com",
                Password = "ruizlu18822",
                Rol = Roles.User,
                CreatedBy = "Seeder",
                CreatedAt = creationDate,
                IsDeleted = false,
            },
            new User
            {
                Id = 14,
                Name = "Karla",
                LastName = "Tetuan",
                Email = "katet@gmail.com",
                Password = "kkktet282",
                Rol = Roles.Admin,
                CreatedBy = "Seeder",
                CreatedAt = creationDate,
                IsDeleted = false,
            },
            new User
            {
                Id = 15,
                Name = "Maria",
                LastName = "Cruz",
                Email = "cruzima@gmail.com",
                Password = "maricru828228",
                Rol = Roles.User,
                CreatedBy = "Seeder",
                CreatedAt = creationDate,
                IsDeleted = false,
            },
            new User
            {
                Id = 16,
                Name = "María",
                LastName = "Luengo",
                Email = "luma@gmail.com",
                Password = "luen7262",
                Rol = Roles.User,
                CreatedBy = "Seeder",
                CreatedAt = creationDate,
                IsDeleted = false,
            },
            new User
            {
                Id = 17,
                Name = "Nerea",
                LastName = "Plaza",
                Email = "nerplaza@gmail.com",
                Password = "palz8181",
                Rol = Roles.User,
                CreatedBy = "Seeder",
                CreatedAt = creationDate,
                IsDeleted = false,
            },
            new User
            {
                Id = 18,
                Name = "Pepe",
                LastName = "Montes",
                Email = "montespe@gmail.com",
                Password = "jsajas8",
                Rol = Roles.User,
                CreatedBy = "Seeder",
                CreatedAt = creationDate,
                IsDeleted = false,
            },
            new User
            {
                Id = 19,
                Name = "Carlos",
                LastName = "Pueblo",
                Email = "puebosss@gmail.com",
                Password = "1323aasdom12",
                Rol = Roles.User,
                CreatedBy = "Seeder",
                CreatedAt = creationDate,
                IsDeleted = false,
            },
            new User
            {
                Id = 20,
                Name = "Concha",
                LastName = "Paz",
                Email = "pazcoc@gmail.com",
                Password = "asasppq871",
                Rol = Roles.User,
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
            },
            new Student
            {
                Id = 4,
                Name = "Test Admin",
                LastName = "Test",
                Birthay = new DateTime(1990, 1, 7),
                CreatedBy = "Seeder",
                CreatedAt = creationDate,
                IsDeleted = false,
                UserId = 4
            },
            new Student
            {
                Id = 5,
                Name = "Nicolas",
                LastName = "Cruz",
                Birthay = new DateTime(1990, 1, 7),
                CreatedBy = "Seeder",
                CreatedAt = creationDate,
                IsDeleted = false,
                UserId = 5
            },
            new Student
            {
                Id = 6,
                Name = "María",
                LastName = "Times",
                Birthay = new DateTime(1990, 1, 7),
                CreatedBy = "Seeder",
                CreatedAt = creationDate,
                IsDeleted = false,
                UserId = 6
            },
            new Student
            {
                Id = 7,
                Name = "Neri",
                LastName = "Lopez",
                Birthay = new DateTime(1990, 1, 7),
                CreatedBy = "Seeder",
                CreatedAt = creationDate,
                IsDeleted = false,
                UserId = 7
            },
            new Student
            {
                Id = 8,
                Name = "Pepe",
                LastName = "Vizio",
                Birthay = new DateTime(1990, 1, 7),
                CreatedBy = "Seeder",
                CreatedAt = creationDate,
                IsDeleted = false,
                UserId = 8
            },
            new Student
            {
                Id = 9,
                Name = "Carlos",
                LastName = "Domingo",
                Birthay = new DateTime(1990, 1, 7),
                CreatedBy = "Seeder",
                CreatedAt = creationDate,
                IsDeleted = false,
                UserId = 9
            },
            new Student
            {
                Id = 10,
                Name = "Nieves",
                LastName = "Montaña",
                Birthay = new DateTime(1990, 1, 7),
                CreatedBy = "Seeder",
                CreatedAt = creationDate,
                IsDeleted = false,
                UserId = 10
            },
            new Student
            {
                Id = 11,
                Name = "Mario",
                LastName = "Sainz",
                Birthay = new DateTime(1990, 1, 7),
                CreatedBy = "Seeder",
                CreatedAt = creationDate,
                IsDeleted = false,
                UserId = 11
            },
            new Student
            {
                Id = 12,
                Name = "Chritian",
                LastName = "Marco",
                Birthay = new DateTime(1990, 1, 7),
                CreatedBy = "Seeder",
                CreatedAt = creationDate,
                IsDeleted = false,
                UserId = 12
            },
            new Student
            {
                Id = 13,
                Name = "Lucas",
                LastName = "Ruiz",
                Birthay = new DateTime(1990, 1, 7),
                CreatedBy = "Seeder",
                CreatedAt = creationDate,
                IsDeleted = false,
                UserId = 13
            },
            new Student
            {
                Id = 14,
                Name = "Karla",
                LastName = "Tetuan",
                Birthay = new DateTime(1990, 1, 7),
                CreatedBy = "Seeder",
                CreatedAt = creationDate,
                IsDeleted = false,
                UserId = 14
            },
            new Student
            {
                Id = 15,
                Name = "Maria",
                LastName = "Cruz",
                Birthay = new DateTime(1990, 1, 7),
                CreatedBy = "Seeder",
                CreatedAt = creationDate,
                IsDeleted = false,
                UserId = 15
            },
            new Student
            {
                Id = 16,
                Name = "María",
                LastName = "Luengo",
                Birthay = new DateTime(1990, 1, 7),
                CreatedBy = "Seeder",
                CreatedAt = creationDate,
                IsDeleted = false,
                UserId = 16
            },
            new Student
            {
                Id = 17,
                Name = "Nerea",
                LastName = "Plaza",
                Birthay = new DateTime(1990, 1, 7),
                CreatedBy = "Seeder",
                CreatedAt = creationDate,
                IsDeleted = false,
                UserId = 17
            },
            new Student
            {
                Id = 18,
                Name = "Pepe",
                LastName = "Montes",
                Birthay = new DateTime(1990, 1, 7),
                CreatedBy = "Seeder",
                CreatedAt = creationDate,
                IsDeleted = false,
                UserId = 18
            },
            new Student
            {
                Id = 19,
                Name = "Carlos",
                LastName = "Pueblo",
                Birthay = new DateTime(1990, 1, 7),
                CreatedBy = "Seeder",
                CreatedAt = creationDate,
                IsDeleted = false,
                UserId = 19
            },
            new Student
            {
                Id = 20,
                Name = "Concha",
                LastName = "Paz",
                Birthay = new DateTime(1990, 1, 7),
                CreatedBy = "Seeder",
                CreatedAt = creationDate,
                IsDeleted = false,
                UserId = 20
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
                },
                new Category
                {
                    Id = 6,
                    Name = "CMS",
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
            },
            new Course
            {
                Id = 4,
                Name = "CSS",
                ShortDescription = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore",
                LongDescription = "Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur?",
                Level = Levels.Basic,
                CreatedBy = "Seeder",
                CreatedAt = creationDate

            },
            new Course
            {
                Id = 5,
                Name = "SASS",
                ShortDescription = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore",
                LongDescription = "Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur?",
                Level = Levels.Advanced,
                CreatedBy = "Seeder",
                CreatedAt = creationDate
            },
            new Course
            {
                Id = 6,
                Name = "Laravel",
                ShortDescription = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore",
                LongDescription = "Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur?",
                Level = Levels.Medium,
                CreatedBy = "Seeder",
                CreatedAt = creationDate
            },
            new Course
            {
                Id = 7,
                Name = "React",
                ShortDescription = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore",
                LongDescription = "Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur?",
                Level = Levels.Basic,
                CreatedBy = "Seeder",
                CreatedAt = creationDate

            },
            new Course
            {
                Id = 8,
                Name = "C#",
                ShortDescription = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore",
                LongDescription = "Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur?",
                Level = Levels.Advanced,
                CreatedBy = "Seeder",
                CreatedAt = creationDate
            },
            new Course
            {
                Id = 9,
                Name = ".NET",
                ShortDescription = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore",
                LongDescription = "Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur?",
                Level = Levels.Medium,
                CreatedBy = "Seeder",
                CreatedAt = creationDate
            },
            new Course
            {
                Id = 10,
                Name = "Wordpress",
                ShortDescription = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore",
                LongDescription = "Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur?",
                Level = Levels.Medium,
                CreatedBy = "Seeder",
                CreatedAt = creationDate
            }
            );
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
                 new { CoursesId = 3, CategoriesId = 2 },
                 new { CoursesId = 4, CategoriesId = 1 },
                 new { CoursesId = 5, CategoriesId = 1 },
                 new { CoursesId = 6, CategoriesId = 2 },
                 new { CoursesId = 6, CategoriesId = 3 },
                 new { CoursesId = 6, CategoriesId = 4 },
                 new { CoursesId = 7, CategoriesId = 1 },
                 new { CoursesId = 7, CategoriesId = 3 },
                 new { CoursesId = 7, CategoriesId = 4 },
                 new { CoursesId = 8, CategoriesId = 2 },
                 new { CoursesId = 9, CategoriesId = 2 },
                 new { CoursesId = 9, CategoriesId = 3 },
                 new { CoursesId = 9, CategoriesId = 4 },
                 new { CoursesId = 10, CategoriesId = 6 }
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
                new { StudentsId = 2, CoursesId = 2 },
                new { StudentsId = 3, CoursesId = 2 },
                new { StudentsId = 3, CoursesId = 5 },
                new { StudentsId = 3, CoursesId = 6 },
                new { StudentsId = 4, CoursesId = 4 },
                new { StudentsId = 4, CoursesId = 5 },
                new { StudentsId = 5, CoursesId = 4 },
                new { StudentsId = 5, CoursesId = 5 },
                new { StudentsId = 6, CoursesId = 2 },
                new { StudentsId = 7, CoursesId = 9 },
                new { StudentsId = 8, CoursesId = 6 },
                new { StudentsId = 8, CoursesId = 7 },
                new { StudentsId = 8, CoursesId = 8 },
                new { StudentsId = 9, CoursesId = 10 },
                new { StudentsId = 9, CoursesId = 4 },
                new { StudentsId = 9, CoursesId = 3 },
                new { StudentsId = 10, CoursesId = 9 },
                new { StudentsId = 11, CoursesId = 1 },
                new { StudentsId = 11, CoursesId = 2 },
                new { StudentsId = 11, CoursesId = 3 },
                new { StudentsId = 12, CoursesId = 1 },
                new { StudentsId = 12, CoursesId = 2 },
                new { StudentsId = 13, CoursesId = 2 },
                new { StudentsId = 13, CoursesId = 5 },
                new { StudentsId = 13, CoursesId = 6 },
                new { StudentsId = 14, CoursesId = 4 },
                new { StudentsId = 14, CoursesId = 5 },
                new { StudentsId = 15, CoursesId = 4 },
                new { StudentsId = 15, CoursesId = 5 },
                new { StudentsId = 16, CoursesId = 2 },
                new { StudentsId = 17, CoursesId = 9 }
                ));




        }
    }
}
