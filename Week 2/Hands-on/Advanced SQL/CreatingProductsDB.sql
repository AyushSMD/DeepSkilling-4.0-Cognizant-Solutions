SELECT * FROM Products;

-- Create and use database
CREATE DATABASE IF NOT EXISTS ShopDB;
USE ShopDB;

-- Drop existing Products table (if any)
DROP TABLE IF EXISTS Products;

-- Create Products table
CREATE TABLE Products (
    ProductID INT AUTO_INCREMENT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10, 2)
);

-- Insert sample data
INSERT INTO Products (ProductName, Category, Price) VALUES 
('iPhone', 'Electronics', 999.00),
('Samsung TV', 'Electronics', 800.00),
('MacBook', 'Electronics', 1299.00),
('HP Laptop', 'Electronics', 999.00),
('Dell Monitor', 'Electronics', 300.00),
('Nike Shoes', 'Apparel', 150.00),
('Adidas Shoes', 'Apparel', 150.00),
('Puma Shirt', 'Apparel', 50.00),
('Levi Jeans', 'Apparel', 80.00),
('Zara Jacket', 'Apparel', 120.00);

SELECT * FROM products;