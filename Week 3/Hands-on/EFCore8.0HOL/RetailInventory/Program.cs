using RetailInventory.Data;
using RetailInventory.Models;

using Microsoft.EntityFrameworkCore;

// using var context = new AppDbContext();

// var electronics = new Category { Name = "Electronics" };
// var groceries = new Category { Name = "Groceries" };

// context.Categories.AddRange(electronics, groceries);

// var product1 = new Product { Name = "Laptop", Price = 75000, Category = electronics };
// var product2 = new Product { Name = "Rice Bag", Price = 1200, Category = groceries };

// context.Products.AddRange(product1, product2);
// context.SaveChanges();

// Console.WriteLine("Data inserted successfully.");

using var context = new AppDbContext();

// 1. Retrieve All Products
var products = await context.Products.ToListAsync();
foreach (var p in products)
    Console.WriteLine($"{p.Name} - ₹{p.Price}");

// 2. Find by ID
var product = await context.Products.FindAsync(1);
Console.WriteLine($"Found: {product?.Name}");

// 3. FirstOrDefault with Condition
var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);
Console.WriteLine($"Expensive: {expensive?.Name}");