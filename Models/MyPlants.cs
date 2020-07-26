using System;
namespace ProPlanter.Models
{
    public class MyPlants
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public int WaterFrequency {get; set;}
        public DateTime LastWateredDate {get; set;}
        public DateTime DatePlanted {get; set;}
        public int Age {get; set;}
    }
}