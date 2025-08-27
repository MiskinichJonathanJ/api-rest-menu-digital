namespace Domain.Entities
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int DishId { get; set; }
        public int Quantity { get; set; }
        public  string  Notes { get; set; }
        public  int StatusId { get; set; }
        public Order OrderNav { get; set; }
        public Dish DishNav { get; set; }
    }
}