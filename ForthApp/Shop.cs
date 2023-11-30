
namespace Shop
{
    public class Shop : ISearchable
    {
        private List<Product> products;
        private List<User> users;
        private List<Order> orders;

        public Shop()
        {
            products = new List<Product>();
            users = new List<User>();
            orders = new List<Order>();
        }

        public void AddProduct(Product product)
        {
            if (products.Contains(product))
            {
                return;
            }

            products.Add(product);
        }

        public void AddUser(User user)
        {
            if (users.Contains(user))
            {
                return;
            }

            users.Add(user);
        }

        public void ProcessOrder(Order order)
        {
            order.status = Enums.OrderStatus.Processing;
            order.status = Enums.OrderStatus.Delivered;
            orders.Add(order);
        }

        public IEnumerable<Product> Search(string searchTerm)
        {
            List<Product> results = new List<Product>();

            foreach (Product product in products)
            {
                if (product.GetName().Contains(searchTerm) ||
                    product.GetDescription().Contains(searchTerm) ||
                    product.GetCategory().ToString().Contains(searchTerm))
                {
                    results.Add(product);
                }
            }

            return results;
        }
    }
}
