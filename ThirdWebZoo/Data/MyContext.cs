using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;
using ThirdWebZoo.Models;

namespace TheZOO.Data
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }

        public DbSet<Category> categories { get; set; }
        public DbSet<Animal> animals { get; set; }
        public DbSet<Comment> comments { get; set; }
        public DbSet<Admin> admins { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new { CategoryId = 1, Name = "Fish", AnimalPicture = "/MainImages/Tuna.jpg" },
                new { CategoryId = 2, Name = "Mammals", AnimalPicture = "/MainImages/Lion.jpg" },
                new { CategoryId = 3, Name = "Birds", AnimalPicture = "/MainImages/Eagle.jpg" },
                new { CategoryId = 4, Name = "Amphibians", AnimalPicture = "/MainImages/Salamandra.jpg" },
                new { CategoryId = 5, Name = "Reptiles", AnimalPicture = "/MainImages/Python.jpg" }
                );

            modelBuilder.Entity<Animal>().HasData(
                new { AnimalId = 1, Name ="Joe", CategoryId= 3, Species = "Eagle", 
                    AnimalAge = 1, AnimalClass = "Birds"},

                new { AnimalId = 2, Name ="Kfir", Species = "Lion", CategoryId = 2,
                    AnimalAge = 3, AnimalClass="Mammals"},

                new { AnimalId = 3, Name ="Edmond", Species = "Snake", CategoryId = 5,
                    AnimalAge = 5, AnimalClass="Reptiles"}
                );

            modelBuilder.Entity<Comment>().HasData(
                new { CommentId = 1, AnimalId = 1, Comments = "a" },
                new { CommentId = 2, AnimalId = 3, Comments = "d" },
                new { CommentId = 3, AnimalId = 3, Comments = "g" },
                new { CommentId = 4, AnimalId = 2, Comments = "b" }
                );

            modelBuilder.Entity<Admin>().HasData(
                new { AdminId = 1, AdminName ="J", Password = "A" },
                new { AdminId = 2, Password = "A" },
                new { AdminId = 3, Password = "A" },
                new { AdminId = 4, Password = "A" },
                new { AdminId = 5, Password = "A" }
                );

            modelBuilder.Entity<AnimalsPictuersModel>().HasData(
                new { AnimalsPictuersModelId = 1, AnimalKind = "Mammals", ImageTitle = "Dolphin"},
                new { AnimalsPictuersModelId = 2, AnimalKind = "Birds", ImageTitle = "Owl" },
                new { AnimalsPictuersModelId = 3, AnimalKind = "Fish", ImageTitle = "Shark" },
                new { AnimalsPictuersModelId = 4, AnimalKind = "Reptiles", ImageTitle = "Black Mamba" }
                );
        }
    }
}

