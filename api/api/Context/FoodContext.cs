using api.Model;
using Microsoft.EntityFrameworkCore;

namespace api.Context
{
    public class FoodContext : DbContext
    {
        private readonly string _appUrl = "http://localhost:4200";
        public DbSet<Food> Foods { get; set; }

        public DbSet<MainDish> MainDishes { get; set; }
        public DbSet<Beverage> Beverages { get; set; }
        public DbSet<Dessert> Desserts { get; set; }
        public DbSet<User> Users { get; set; }
        //public DbSet<ComboMeal> ComboMeals { get; set; }
        public IConfiguration Configuration { get; set; }

        public FoodContext()
        {
            Configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true).Build();
        }


        public FoodContext(DbContextOptions<FoodContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.EnableSensitiveDataLogging();
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //optionsBuilder.UseSqlServer("Server=LAPTOP-JMGED3R4;Database=Lab;Trusted_Connection=True;");
                optionsBuilder.UseSqlServer(Configuration.GetConnectionString("food"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MainDish>().HasData(InitMainDish());
            modelBuilder.Entity<Beverage>().HasData(InitDrink());
            modelBuilder.Entity<Dessert>().HasData(InitDessert());
        }

        private IEnumerable<MainDish> InitMainDish()
        {
            yield return new MainDish()
            {
                Id = Guid.NewGuid(),
                Name = "火腿蛋漢堡",
                Price = 70,
                ImageUrl=$"{_appUrl}/assets/main3.jpg"
            };

            yield return new MainDish()
            {
                Id = Guid.NewGuid(),
                Name = "鱈魚堡",
                Price = 65,
                ImageUrl = $"{_appUrl}/assets/main1.jpg"
            };
            yield return  new MainDish()
            {
                Id = Guid.NewGuid(),
                Name = "海洋珍珠堡",
                Price = 75,
                ImageUrl = $"{_appUrl}/assets/main2.jpg"
            };

            yield return new MainDish()
            {
                Id = Guid.NewGuid(),
                Name = "燒肉堡",
                Price = 80,
                ImageUrl = $"{_appUrl}/assets/main4.jpg"
            };

            yield return new MainDish()
            {
                Id = Guid.NewGuid(),
                Name = "美式炸雞",
                Price = 85,
                ImageUrl = $"{_appUrl}/assets/main5.jpg"
            };
        }

        private IEnumerable<Beverage> InitDrink()
        {
            yield return new Beverage()
            {
                Id = Guid.NewGuid(),
                Name = "可口可樂",
                Price = 30,
                ImageUrl = $"{_appUrl}/assets/beverage4.jpg"
            };

            yield return new Beverage()
            {
                Id = Guid.NewGuid(),
                Name = "雪碧",
                Price = 30,
                ImageUrl = $"{_appUrl}/assets/beverage3.jpg"
            };
            yield return new Beverage()
            {
                Id = Guid.NewGuid(),
                Name = "蘋果汁",
                Price = 25,
                ImageUrl = $"{_appUrl}/assets/beverage1.jpg"
            };

            yield return new Beverage()
            {
                Id = Guid.NewGuid(),
                Name = "柳橙汁",
                Price = 25,
                ImageUrl = $"{_appUrl}/assets/beverage2.jpg"
            };
        }

        private IEnumerable<Dessert> InitDessert()
        {
            yield return new Dessert()
            {
                Id = Guid.NewGuid(),
                Name = "巧克力冰淇淋",
                Price = 30,
                ImageUrl = $"{_appUrl}/assets/dessert3.jpg"
            };

            yield return new Dessert()
            {
                Id = Guid.NewGuid(),
                Name = "巧克力蛋糕",
                Price = 30,
                ImageUrl = $"{_appUrl}/assets/dessert1.jpg"
            };
            yield return new Dessert()
            {
                Id = Guid.NewGuid(),
                Name = "蛋塔",
                Price = 25,
                ImageUrl = $"{_appUrl}/assets/dessert2.jpg"
            };

        }
    }
}
