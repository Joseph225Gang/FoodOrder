

using System.ComponentModel.DataAnnotations;

namespace api.Model
{
    public class Food
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
