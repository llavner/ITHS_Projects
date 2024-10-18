namespace SOLID

{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

    }



    class Product
    {

        public string Name { get; set; }

        public Product(string name)
        {
            this.Name = name;
        }

    }

    class ShoppingCart
    {
        private List<Product> products;

        public void ShowProduct()
        {

            

        }

        public void LoadProducts()
        {
            var reader = new DatabaseReader();
            
        }


    }

    class DatabaseReader : IReader
    {

        public List<Product> LoadProducts()
        {
            Console.WriteLine("Loading products from database.");

            var products = new List<Product>();

            products.Add(new Product("database product A"));
            products.Add(new Product("database product A"));

            return products;
        }

    }

    interface IReader
    {
        public List<Product> LoadProducts();

    }
}
