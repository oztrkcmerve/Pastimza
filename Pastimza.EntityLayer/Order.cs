namespace Pastimza.EntityLayer.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public int TotalCalories { get; set; }
        
        public DateTime? DeliveryDate { get; set; }
        public string? DeliveryAddress { get; set; }
        public string? GiftNote { get; set; }
        public string? VideoMessageUrl { get; set; }
        
        public List<OrderItem> OrderItems { get; set; }
    }
}
