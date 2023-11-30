

namespace Shop
{
    public class User
    {
        private string login;
        private string password;
        private List<Order> orders;

        public User(string login, string password)
        {
            this.login = login;
            this.password = password;
            this.orders = new List<Order>();
        }

        public string GetLogin()
        {
            return login;
        }

        public string GetPassword()
        {
            return password;
        }

        public List<Order> GetOrders()
        {
            return orders;
        }

        public void AddOrder(Order order)
        {
            orders.Add(order);
        }
    }
}
