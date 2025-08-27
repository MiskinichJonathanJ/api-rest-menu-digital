namespace MenuDigitalRestaurante.Entities
{
    public class  Order
    {
        public int Id { get; set; }
        public int DeliveryTypeID { get; set; }
        public string DeliveryTo { get; set; }
        public  int OverallStatusID { get; set; }
        public  string Notes { get; set; }
        public decimal Price { get; set; }
        public Status StatusNav { get; set; }
        public DeliveryType DeliveryTypeNav { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}