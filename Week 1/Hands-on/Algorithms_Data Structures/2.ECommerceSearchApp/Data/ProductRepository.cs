using ECommerceSearchApp.Models;

namespace ECommerceSearchApp.Data
{
    public static class ProductRepository
    {
        public static Product[] GetSampleProducts()
        {
            return new Product[]
            {
                new Product(1, "Laptop", "Electronics"),
                new Product(2, "Shoes", "Footwear"),
                new Product(3, "Phone", "Electronics"),
                new Product(4, "Watch", "Accessories"),
                new Product(5, "Book", "Stationery")
            };
        }
    }
}
