using System;
using System.ComponentModel.DataAnnotations;

namespace ProPlanterAPI.Models
{
    public class MyPlant
    {
        public int Id {get; set;}
        [Required]
        public string Name {get; set;}
        public string Type {get; set;}
        public int WaterFrequency {get; set;}
        public DateTime? LastWateredDate {get; set;}
        public int? FertilizeFrequency {get; set;}
        public DateTime? LastFertilizedDate {get; set;}
        public DateTime? DatePlanted {get; set;}
        public int? Quantity {get; set;}
        public int? QuantitySold { get; set; }
        public int? Price { get; set; }


    }
}