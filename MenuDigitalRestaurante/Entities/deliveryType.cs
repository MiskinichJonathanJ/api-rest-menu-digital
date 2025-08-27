namespace MenuDigitalRestaurante.Entities
{
	public class DeliveryType
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public  ICollection<Order> OrdersNav { get; set; }
	}
}