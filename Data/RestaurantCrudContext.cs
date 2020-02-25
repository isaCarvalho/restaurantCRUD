using Microsoft.EntityFrameworkCore;

namespace restaurantCRUD.Data
{
    public class RestaurantCrudContext : DbContext
    {
        public RestaurantCrudContext(
            DbContextOptions<RestaurantCrudContext> options)
            : base(options)
        {
        }

        public DbSet<restaurantCRUD.Models.Dish> Dish { get; set; }
    }
}