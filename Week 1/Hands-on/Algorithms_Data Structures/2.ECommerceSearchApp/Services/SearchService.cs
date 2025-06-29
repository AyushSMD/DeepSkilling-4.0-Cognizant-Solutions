using ECommerceSearchApp.Models;

namespace ECommerceSearchApp.Services
{
    public static class SearchService
    {
        public static Product LinearSearch(Product[] products, string targetName)
        {
            foreach (Product product in products)
            {
                if (product.ProductName.Equals(targetName, StringComparison.OrdinalIgnoreCase))
                {
                    return product;
                }
            }
            return null;
        }

        public static Product BinarySearch(Product[] sortedProducts, string targetName)
        {
            int left = 0;
            int right = sortedProducts.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                int comparison = string.Compare(sortedProducts[mid].ProductName, targetName, StringComparison.OrdinalIgnoreCase);

                if (comparison == 0)
                    return sortedProducts[mid];
                else if (comparison < 0)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return null;
        }
    }
}
