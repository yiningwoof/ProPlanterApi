using Microsoft.EntityFrameworkCore;

namespace ProPlanter.Models
{
    public class MyPlantsContext : DbContext
    {
        public MyPlantsContext(DbContextOptions<MyPlantsContext> options) :base (options)
        {

        }

        public DbSet<MyPlants> MyPlantsItems {get; set;} // create a dbset using MyPlants class
        
    }
}