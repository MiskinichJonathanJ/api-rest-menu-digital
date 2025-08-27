namespace MenuDigitalRestaurante.Entities
{
    public class Category
    {
        public  int  Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public ICollection<Dish> dishes { get; set; }
    }
}