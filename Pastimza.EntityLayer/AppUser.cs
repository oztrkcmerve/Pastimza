namespace Pastimza.EntityLayer.Entities
{
    public class AppUser
    {
        public int AppUserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int DailyCalorieLimit { get; set; }
        public string? Allergies { get; set; } // Comma separated or just text
        
        public List<Order> Orders { get; set; }
    }
}
