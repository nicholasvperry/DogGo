using DogGo2.Models;

namespace DogGo2.Models
{
    public class Walker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NeighborhoodId { get; set; }
        public string ImageUrl { get; set; }
        public Neighborhood Neighborhood { get; set; }
        public Owner Owner { get; set; }
        public Dog Dog { get; set; }
        public Walks Walks { get; set; }
    }
}