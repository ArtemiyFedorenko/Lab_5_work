

namespace Shop
{
    public interface ISearchable
    {
        IEnumerable<Product> Search(string searchTerm);
    }
}
