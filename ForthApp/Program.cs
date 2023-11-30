

namespace Shop
{
    class Program
    {
        public static void Main()
        {
            Shop shop = new Shop();

            Product product1 = new Product("Apple", 2, "A delicious fruit.", Enums.Category.Fruit);
            shop.AddProduct(product1);

            Product product2 = new Product("Orange", 3, "A citrus fruit.", Enums.Category.Fruit);
            shop.AddProduct(product2);

            User user = new User("johndoe", "password");
            shop.AddUser(user);

            Order order = new Order(new List<Product>() { product1, product2 }, 2, 4, Enums.OrderStatus.New);
            shop.ProcessOrder(order);

            IEnumerable<Product> results = shop.Search("fruit");
            foreach (Product product in results)
            {
                Console.WriteLine(product.GetName());
            }
        }
    }
}
