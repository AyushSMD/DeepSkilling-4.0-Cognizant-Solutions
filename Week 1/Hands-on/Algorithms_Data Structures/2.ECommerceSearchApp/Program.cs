using System;
using System.Linq;
using System.Diagnostics;
using ECommerceSearchApp.Models;
using ECommerceSearchApp.Data;
using ECommerceSearchApp.Services;

class Program
{
    static void Main()
    {
        Product[] products = ProductRepository.GetSampleProducts();

        Console.Write("Enter product name to search: ");
        string searchTerm = Console.ReadLine();

        // === LINEAR SEARCH ===
        Console.WriteLine("\n=== Linear Search ===");
        Stopwatch stopwatch1 = Stopwatch.StartNew();
        var result1 = SearchService.LinearSearch(products, searchTerm);
        stopwatch1.Stop();

        if (result1 != null)
        {
            Console.WriteLine("Product Found:");
            Console.WriteLine($"ID: {result1.ProductId}");
            Console.WriteLine($"Name: {result1.ProductName}");
            Console.WriteLine($"Category: {result1.Category}");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
        Console.WriteLine($"Time Taken: {stopwatch1.Elapsed.TotalMilliseconds} ms\n");

        // === BINARY SEARCH ===
        Console.WriteLine("=== Binary Search ===");
        var sortedProducts = products.OrderBy(p => p.ProductName).ToArray();
        Stopwatch stopwatch2 = Stopwatch.StartNew();
        var result2 = SearchService.BinarySearch(sortedProducts, searchTerm);
        stopwatch2.Stop();

        if (result2 != null)
        {
            Console.WriteLine("Product Found:");
            Console.WriteLine($"ID: {result2.ProductId}");
            Console.WriteLine($"Name: {result2.ProductName}");
            Console.WriteLine($"Category: {result2.Category}");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
        Console.WriteLine($"Time Taken: {stopwatch2.Elapsed.TotalMilliseconds} ms");
    }
} 