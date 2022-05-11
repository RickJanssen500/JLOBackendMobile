namespace DAL.Models
{
    public class Order
    { 
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public DateTime? pickup { get; set; }
        public bool Complete { get; set; }
        public bool Picked { get; set; }
    }
}
