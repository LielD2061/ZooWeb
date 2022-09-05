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
        public DbSet<Category>? categories { get; set; }
        public DbSet<Animal>? animals { get; set; }
        public DbSet<Comment>? comments { get; set; }
        public DbSet<Admin>? admins { get; set; }
        public DbSet<User>? users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(

                new { CategoryId = 1, Name = "Fish", AnimalPicture = "/MainImages/Tuna.jpg" },
                new { CategoryId = 2, Name = "Mammals", AnimalPicture = "/MainImages/Lion.jpg" },
                new { CategoryId = 3, Name = "Birds", AnimalPicture = "/MainImages/Eagle.jpg" },
                new { CategoryId = 4, Name = "Amphibians", AnimalPicture = "/MainImages/Salamandra.jpg" },
                new { CategoryId = 5, Name = "Reptiles", AnimalPicture = "/MainImages/Python.jpg" }
                );

            #region Animal Seeding
            modelBuilder.Entity<Animal>().HasData(
                
                new{
                    AnimalId = 1,
                    Description = "any of many large, heavy-beaked, big-footed birds of prey belonging to the family Accipitridae.",
                    Name = "Joe",
                    CategoryId = 3,
                    Species = "Eagle",
                    AnimalAge = 1,
                    AnimalClass = "Birds",
                    AnimalPicture = "/MainImages/Eagle.jpg"
                },
                new{
                    AnimalId = 2,
                    Description = "Large, powerfully built cat (family Felidae) that is second in size only to the tiger.",
                    Name = "Kfir",
                    Species = "Lion",
                    CategoryId = 2,
                    AnimalAge = 3,
                    AnimalClass = "Mammals",
                    AnimalPicture = "/MainImages/Lion.jpg"
                },
                new{
                    AnimalId = 3,
                    Description = "Also called serpent, any of more than 3,400 species of reptiles distinguished by their limbless condition and greatly elongated body and tail.",
                    Name = "Edmond",
                    Species = "Snake",
                    CategoryId = 5,
                    AnimalAge = 5,
                    AnimalClass = "Reptiles",
                    AnimalPicture = "/MainImages/Python.jpg"
                },
                new{
                    AnimalId = 4,
                    Description = "Green iguanas are large beautiful looking lizards found in the Americas. Despite their name, Green iguanas can come in different colors and types.",
                    Name = "Lizy",
                    Species = "Iguana",
                    CategoryId = 5,
                    AnimalAge = 8,
                    AnimalClass = "Reptiles",
                    AnimalPicture = "/SeconImages/Iguana.jpeg"
                },
                new{
                    AnimalId=5,
                    Description= "Alligator, either of two crocodilians related to the tropical American caimans.",
                    Name="Igor",
                    Species= "Aligaator",
                    CategoryId= 5,
                    AnimalAge= 5,  
                    AnimalClass= "Reptiles",
                    AnimalPicture= "/SeconImages/Aligaator.jpg"
                },
                new{
                    AnimalId = 6,
                    Description = "Barn owl, any of several species of nocturnal birds of prey of the genus Tyto.",
                    Name = "Hedwig",
                    Species = "Barn Owl",
                    CategoryId = 3,
                    AnimalAge = 3,
                    AnimalClass = "Birds",
                    AnimalPicture = "/SeconImages/BarnOwl.jpg"
                },
                new{
                    AnimalId = 7,
                    Description = "The Eastern Screech-Owl is a short, stocky bird, with a large head and almost no neck. Its wings are rounded; its tail is short and square. Pointed ear tufts are often raised, lending its head a distinctive silhouette.",
                    Name = "George",
                    Species = "EasterScreetch",
                    CategoryId = 3,
                    AnimalAge = 2,
                    AnimalClass = "Birds",
                    AnimalPicture = "/SeconImages/EasterScreetch.jpg"
                },
                new{
                    AnimalId = 8,
                    Description = "Sharks are fishes and most have the typical fusiform body shape. Like other fishes, sharks are ectothermic, live in water, have fins, and breathe with gills.",
                    Name = "Keny",
                    Species = "Shark",
                    CategoryId = 1,
                    AnimalAge = 8,
                    AnimalClass = "Fish",
                    AnimalPicture = "/SeconImages/Shark.png"
                },
                new{
                    AnimalId = 9,
                    Description = "Salmons include seven species of Pacific salmon and one species of Atlantic salmon. They’re found in tributaries of the Pacific and Atlantic Oceans, and most species are anadromous: They are born in streams and rivers, migrate out to the open sea, and then return to freshwater again to reproduce.",
                    Name = "Nemo",
                    Species = "Salmon",
                    CategoryId = 1,
                    AnimalAge = 7,
                    AnimalClass = "Fish",
                    AnimalPicture = "/SeconImages/Salmon.jpg"
                },
                new{
                    AnimalId = 10,
                    Description = "Tree frogs are not a distinct taxonomic group of animals, but rather, the term refers generally to frogs that spend most of their time in trees or higher vegetation. There are about 800 species of tree frogs, some of which are classified as tree frogs, which are aquatic or terrestrial.",
                    Name = "Merdith",
                    Species = "Frog",
                    CategoryId = 4,
                    AnimalAge = 4,
                    AnimalClass = "Amphibians",
                    AnimalPicture = "/SeconImages/tree-frog.jpg"
                },
                new{
                    AnimalId = 11,
                    Description = "Newts are small semi-aquatic amphibians that look like a cross between a frog and a lizard. Newts possess several interesting characteristics. For example, though they may look cute and harmless, they can be dangerous; toxins secreted through the skin as a defense mechanism could kill a person.",
                    Name = "Neothon",
                    Species = "newt",
                    CategoryId = 4,
                    AnimalAge = 3,
                    AnimalClass = "Amphibians",
                    AnimalPicture = "/SeconImages/newt.jpg"
                },
                new{
                    AnimalId = 12,
                    Description = "Dolphins are small-toothed cetaceans easily recognizable by their curved mouths, which give them a permanent “smile.” There are 36 dolphin species, found in every ocean.",
                    Name = "Tzvi",
                    Species = "Dolphin",
                    CategoryId = 2,
                    AnimalAge = 4,
                    AnimalClass = "Mammals",
                    AnimalPicture = "/SeconImages/dolphin.jpg"
                },
                new{
                    AnimalId = 13,
                    Description = "Giraffes are the world's tallest mammals, thanks to their towering legs and long necks. A giraffe's legs alone are taller than many humans—about 6 feet . These long legs allow giraffes to run as fast as 35 miles an hour over short distances and cruise comfortably at 10 miles an hour over longer distances.",
                    Name = "Memel",
                    Species = "Giraffe",
                    CategoryId = 2,
                    AnimalAge = 6,
                    AnimalClass = "Mammals",
                    AnimalPicture = "/SeconImages/giraffe.jpg"
                },
                new{
                    AnimalId = 14,
                    Description = "Orang-utans have a characteristic ape-like shape, shaggy reddish fur and grasping hands and feet. Their powerful arms are stronger and longer than their legs and can reach 2m in length, long enough to touch their ankles when they stand.",
                    Name = "Tapuz",
                    Species = "Orangutan",
                    CategoryId = 2,
                    AnimalAge = 9,
                    AnimalClass = "Mammals",
                    AnimalPicture = "/SeconImages/orangutan.jpg"
                }
                );
            #endregion

            //modelBuilder.Entity<Comment>().HasData(
            //    new { CommentId = 1, AnimalId = 1, Comments = "a" },
            //    new { CommentId = 2, AnimalId = 3, Comments = "d" },
            //    new { CommentId = 3, AnimalId = 3, Comments = "g" },
            //    new { CommentId = 4, AnimalId = 2, Comments = "b" }
            //    );

            modelBuilder.Entity<Admin>().HasData(
                new { AdminId = 1, AdminName = "Liel", Password = "A" },
                new { AdminId = 2, AdminName = "Saar", Password = "A" }
                );

            modelBuilder.Entity<AnimalsPictuersModel>().HasData(
                new { AnimalsPictuersModelId = 1, AnimalKind = "Mammals", ImageTitle = "Dolphin" },
                new { AnimalsPictuersModelId = 2, AnimalKind = "Birds", ImageTitle = "Owl" },
                new { AnimalsPictuersModelId = 3, AnimalKind = "Fish", ImageTitle = "Shark" },
                new { AnimalsPictuersModelId = 4, AnimalKind = "Reptiles", ImageTitle = "Black Mamba" }
                );
        }
    }
}

