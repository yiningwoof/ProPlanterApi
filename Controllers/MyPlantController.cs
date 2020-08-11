using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

using ProPlanterAPI.Models;

namespace ProPlanterAPI.Controllers
{
    [ApiController]
    public class MyPlantController : ControllerBase // instead of Controller b/c is controller without view support
    {
        private readonly MyPlantContext _context;
        
        public MyPlantController(MyPlantContext context)
        {
            _context = context;
        }

        // Get: api/myplants
        [Route("api/[controller]")]
        [HttpGet]
        public ActionResult<IEnumerable<MyPlant>> GetMyPlant()
        {
            return _context.MyPlantItems;
        }

        // GET: api/myplants/id
        [Route("api/[controller]/{id}")]
        [HttpGet]
        public ActionResult<MyPlant> GetMyPlantItem(int id)
        {
            var myPlantItem = _context.MyPlantItems.Find(id);
            if (myPlantItem == null)
            {
                return NotFound();
            }
            return myPlantItem;
        }

        [Route("api/[controller]")]
        [HttpPost]
        public ActionResult<MyPlant> PostMyPlantItem(MyPlant myPlant)
        {
            _context.MyPlantItems.Add(myPlant);
            _context.SaveChanges();
            return CreatedAtAction("GetMyPlantItem", new MyPlant { Id = myPlant.Id }, myPlant);
        }

        [Route("api/[controller]/waterreminder/{name}")]
        [HttpGet]
        public ActionResult<DateTime> GetPlantNextWaterDate(string name)
        {
            string lowerName = name.ToLower();
            var wateredPlant = _context.MyPlantItems.Where(p => p.Name == lowerName).FirstOrDefault();
            DateTime lastWateredDate = (DateTime)wateredPlant.LastWateredDate;
            DateTime nextWaterDate = lastWateredDate.AddDays(wateredPlant.WaterFrequency);
            return nextWaterDate.Date;
        }

    }
}