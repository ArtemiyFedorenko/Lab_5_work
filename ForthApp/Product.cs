
namespace Shop
{
    public class Product : ISearchable
    {
        private string name;
        private decimal price;
        private string description;
        private Enums.Category category;

        public Product(string name, decimal price, string description, Enums.Category category)
        {
            this.name = name;
            this.price = price;
            this.description = description;
            this.category = category;
        }

        public string GetName()
        {
            return name;
        }

        public decimal GetPrice()
        {
            return price;
        }

        public string GetDescription()
        {
            return description;
        }

        public Enums.Category GetCategory()
        {
            return category;
        }

        public IEnumerable<Product> Search(string searchTerm)
        {
            if (name.Contains(searchTerm) || description.Contains(searchTerm) || category.ToString().Contains(searchTerm))
            {
                return new List<Product> { this };
            }

            return new List<Product>();
        }
    }
}
