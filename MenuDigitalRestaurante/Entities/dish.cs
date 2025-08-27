namespace MenuDigitalRestaurante.Entities
{
    public class Dish
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public  bool IsAvailable { get; set; }
        public Category CategoryNav { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}