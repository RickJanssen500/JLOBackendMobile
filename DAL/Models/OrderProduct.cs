namespace DAL.Models
{
    public class OrderProduct
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Product product { get; set; }
        public int Amount { get; set; }
        public bool Picked { get; set; }
        public int? PickedAmount { get; set; }

    }
}
