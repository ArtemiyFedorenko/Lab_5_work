

namespace Shop
{
    public class Order
    {
        private List<Product> products;
        private int quantity;
        private decimal totalPrice;
        public Enums.OrderStatus status;

        public Order(List<Product> products, int quantity, decimal totalPrice, Enums.OrderStatus status)
        {
            this.products = products;
            this.quantity = quantity;
            this.totalPrice = totalPrice;
            this.status = status;
        }

        public List<Product> GetProducts()
        {
            return products;
        }

        public int GetQuantity()
        {
            return quantity;
        }

        public decimal GetTotalPrice()
        {
            return totalPrice;
        }

        public Enums.OrderStatus GetStatus()
        {
            return status;
        }
    }
}
