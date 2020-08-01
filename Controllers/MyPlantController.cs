using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        // Get: api/myplant
        [HttpGet]
        public ActionResult<IEnumerable<MyPlant>> GetMyPlant()
        {
            return _context.MyPlantItems;
        }

        // GET: api/myplant/id
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

        // POST: api/myplant
        [HttpPost]
        public ActionResult<MyPlant> PostMyPlantItem(MyPlant myPlant)
        {
            _context.MyPlantItems.Add(myPlant);
            _context.SaveChanges();
            return CreatedAtAction("GetMyPlantItem", new MyPlant{Id = myPlant.Id}, myPlant);
        }

        // PUT: api/myplant/id
        [HttpPut("{id}")]
        public ActionResult<MyPlant> PutMyPlantItem(int id, MyPlant myPlant)
        {
            if (id != myPlant.Id)
            {
                return BadRequest();

            }
            _context.Entry(myPlant).State = EntityState.Modified; // marking what is modified and only save that piece in _context
            _context.SaveChanges();
            return NoContent();
        }

        // DELETE: api/myplant/id
        [HttpDelete("{id}")]
        public ActionResult<MyPlant> DeleteMyPlantItem(int id)
        {
            var myPlantItem = _context.MyPlantItems.Find(id);
            if (myPlantItem == null)
            {
                return NotFound();
            }
            _context.MyPlantItems.Remove(myPlantItem);
            _context.SaveChanges();
            return myPlantItem;
        }

        

    }
}