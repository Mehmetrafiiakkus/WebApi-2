namespace WebApı_2.Models
{
    public class ProductManage
    {
        public static List<Product> Products { get; set; }

        static ProductManage()
        {

          Products= new List<Product>() 
            { 
                new Product(1,"telefon",20,10000),
                new Product(2,"tv",30,15000),
                new Product(3,"laptop",12,25000)
            };
        }

        public static void Add(Product product)
        {
            Products.Add(product);
        }
        public static void Delete(Product product)
        {
            Products.Remove(product);
        }

        public static Product Get(int id)
        {
            return Products.FirstOrDefault(p => p.Id == id);
        }
    }
}
