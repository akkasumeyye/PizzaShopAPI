using Microsoft.EntityFrameworkCore;
using PizzaShopAPI.Entities;

namespace PizzaShopAPI.Data
{
    public class RestaurantContext : DbContext
    {
        public DbSet<RestaurantsEntities> Restaurants { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=RestaurantDB");
        }
    }
}
