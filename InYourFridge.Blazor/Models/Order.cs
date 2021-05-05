namespace InYourFridge.Blazor.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int IngredientId { get; set; }
        public virtual Ingredient Ingredient { get; set; }
        public int Quantity { get; set; }
        public bool IsActive => (Quantity > 0);
    }
}