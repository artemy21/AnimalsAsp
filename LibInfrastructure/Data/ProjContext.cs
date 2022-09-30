using LibCore.Models;
using Microsoft.EntityFrameworkCore;

namespace LibInfrastructure.Data
{
    public class ProjContext : DbContext
    {
        public ProjContext(DbContextOptions<ProjContext> options) : base(options)
        {
        }

        public virtual DbSet<Category>? Categories { get; set; }
        public virtual DbSet<Animal>? Animals { get; set; }
        public virtual DbSet<Comment>? Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new { Id = 1, Name = "Fish" },
                new { Id = 2, Name = "Bird" },
                new { Id = 3, Name = "Reptile" },
                new { Id = 4, Name = "Mammals" }
            );

            modelBuilder.Entity<Animal>().HasData(
                new
                {
                    Id = 1,
                    Name = "Cat",
                    Description = "A cat is a furry animal that has a long tail and sharp claws. Cats are often kept as pets.",
                    ImageUrl = "https://i.natgeofe.com/n/46b07b5e-1264-42e1-ae4b-8a021226e2d0/domestic-cat_thumb.jpg",
                    CategoryId = 4
                },

                new
                {
                    Id = 2,
                    Name = "Dog",
                    Description = "The dog is a pet animal. A dog has sharp teeth so that it can eat flesh very easily, it has four legs, two ears, two eyes, a tail, a mouth, and a nose. It is a very clever animal and is very useful in catching thieves. It runs very fast, barks loudly and attacks the strangers.",
                    ImageUrl = "https://post.medicalnewstoday.com/wp-content/uploads/sites/3/2020/02/322868_1100-800x825.jpg",
                    CategoryId = 4
                },

                new
                {
                    Id = 3,
                    Name = "Shark",
                    Description = "Like other fishes, sharks are cold-blooded, have fins, live in the water, and breathe with gills. A shark's skeleton is made of cartilage. A shark's fusiform (rounded and tapering at both ends) body shape reduces drag and requires minimum energy to swim. Sharks eat far less than most people imagine.",
                    ImageUrl = "https://paperwriter.ca/wp-content/uploads/2022/07/Encounters-with-sharks-are-increasing-Why.jpg",
                    CategoryId = 1
                },

                new
                {
                    Id = 4,
                    Name = "Crocodile",
                    Description = "Crocodiles have powerful jaws with many conical teeth and short legs with clawed webbed toes. They share a unique body form that allows the eyes, ears, and nostrils to be above the water surface while most of the animal is hidden below. The tail is long and massive, and the skin is thick and plated.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/35/Saltwater_crocodile.jpg/640px-Saltwater_crocodile.jpg",
                    CategoryId = 3
                },

                new
                {
                    Id = 5,
                    Name = "Eagle",
                    Description = "In general, an eagle is any bird of prey more powerful than a buteo. An eagle may resemble a vulture in build and flight characteristics but has a fully feathered (often crested) head and strong feet equipped with great curved talons.",
                    ImageUrl = "https://www.thoughtco.com/thmb/nhezwxPKb0WrFp_5ogIuuOh2IhA=/2576x2576/smart/filters:no_upscale()/american-bald-eagle-head-in-front-of-american-flag-950701786-5b85581346e0fb0025e00b06.jpg",
                    CategoryId = 2
                }
            );

            modelBuilder.Entity<Comment>().HasData(
                new { Id = 1, AnimalId = 1, Content = "this is a cat comment" },
                new { Id = 2, AnimalId = 1, Content = "wow a cat" },
                new { Id = 3, AnimalId = 3, Content = "spooky" }
            );
        }
    }
}
