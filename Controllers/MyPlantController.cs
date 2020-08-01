using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProPlanter.Models;

namespace ProPlanter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyPlantController : ControllerBase // instead of Controller b/c is controller without view support
    {
        private readonly MyPlantContext _context;
        
        public MyPlantController(MyPlantContext context)
        {
            _context = context;
        }

        // Get: api/myplants
        [HttpGet]
        public ActionResult<IEnumerable<MyPlant>> GetMyPlant()
        {
            return _context.MyPlantItems;
        }

        // GET: api/myplants/id
        [HttpGet("{id}")]
        public ActionResult<MyPlant> GetMyPlantItem(int id)
        {
            var myPlantItem = _context.MyPlantItems.Find(id);
            if (myPlantItem == null)
            {
                return NotFound();
            }
            return myPlantItem;
        }

        [HttpPost]
        public ActionResult<MyPlant> PostMyPlantItem(MyPlant myPlant)
        {
            _context.MyPlantItems.Add(myPlant);
            _context.SaveChanges();
            return CreatedAtAction("GetMyPlantItem", new MyPlant{Id = myPlant.Id}, myPlant);
        }

        // POST: api/myplants
        // [HttpPost]
        // public ActionResult<MyPlant> PostMyPlantItem(MyPlant)
        // {

        // }

    }
}