namespace Webstore.Models
{
    public abstract class Product
    {
        public int Id { get; set; }
        public Type Type { get; set; }
        public decimal Price { get; set; }
    }
}