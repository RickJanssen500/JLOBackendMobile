namespace DAL.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Temp { get; set; }
        public string? EAN { get; set; }
        public float Price { get; set; }
        public Category? category { get; set; }
        public int Stock { get; set; }
    }
}
