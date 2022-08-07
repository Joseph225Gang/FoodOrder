using System.ComponentModel.DataAnnotations.Schema;

namespace api.Model
{
    public class ComboMeal
    {
        public Guid Id { get; set; }

        public Guid MainDishId { get; set; }
        [ForeignKey("MainDishId")]
        public MainDish MainDish { get; set; }
        public Guid DrinkId { get; set; }
        [ForeignKey("BeverageId")]
        public Beverage Beverage { get; set; }
        public Guid DessertId { get; set; }
        [ForeignKey("DessertId")]
        public Food Dessert { get; set; }
        public int TotalPrice { get; set; }
    }
}
