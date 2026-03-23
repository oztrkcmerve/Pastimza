namespace Pastimza.EntityLayer.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<Ingredient> Ingredients { get; set; }
    }
}
