namespace Pastimza.EntityLayer.Entities
{
    public class Ingredient
    {
        public int IngredientId { get; set; }
        public string IngredientName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitCalorie { get; set; }
        public bool HasAllergenRisk { get; set; }
        public string? DietType { get; set; } // Vegan, Gluten-free etc.
        
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
