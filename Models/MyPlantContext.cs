using Microsoft.EntityFrameworkCore;

namespace ProPlanterAPI.Models
{
    public class MyPlantContext : DbContext
    {
        public MyPlantContext(DbContextOptions<MyPlantContext> options) :base (options)
        {

        }

        public DbSet<MyPlant> MyPlantItems {get; set;} // create a dbset using MyPlant class
        
    }
}