using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
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
        }
    }
}
