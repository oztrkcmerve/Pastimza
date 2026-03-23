namespace Pastimza.EntityLayer.Entities
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        
        public int OrderId { get; set; }
        public Order Order { get; set; }
        
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
        
        public int Quantity { get; set; } // Default 1 for components
    }
}
