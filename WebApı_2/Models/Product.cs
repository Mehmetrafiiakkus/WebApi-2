namespace WebApı_2.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public Product()
        {

        }

        public Product(int id, string name, int stock, decimal price)
        {
            this.Id = id;
            this.Name = name;
            this.Stock = stock;
            this.Price = price;


        }
    }

}
