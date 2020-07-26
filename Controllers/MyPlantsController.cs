using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProPlanter.Models;

namespace ProPlanter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyPlantsController : ControllerBase // instead of Controller b/c is controller without view support
    {
        private readonly MyPlantsContext _context;
        
        public MyPlantsController(MyPlantsContext context)
        {
            _context = context;
        }

        // Get: api/myplants
        [HttpGet]
        public ActionResult<IEnumerable<MyPlants>> GetMyPlants()
        {
            return _context.MyPlantsItems;
        }

        // GET: api/myplants/id
        [HttpGet("{id}")]
        public ActionResult<MyPlants> GetMyPlantItem(int id)
        {
            var myPlantItem = _context.MyPlantsItems.Find(id);
            if (myPlantItem == null)
            {
                return NotFound();
            }
            return myPlantItem;
        }

    }
}