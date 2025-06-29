-- Use ROW_NUMBER() to assign a unique rank within each category
SELECT 
    ProductID,
    ProductName,
    Category,
    Price,
    ROW_NUMBER() OVER (PARTITION BY Category ORDER BY Price DESC) AS RowNum
FROM Products;


-- Use RANK() and DENSE_RANK() to compare how ties are handled.
SELECT 
    ProductID,
    ProductName,
    Category,
    Price,
    RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS RankNum
FROM Products;


-- and DENSE_RANK()
SELECT 
    ProductID,
    ProductName,
    Category,
    Price,
    DENSE_RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS DenseRank
FROM Products;

SELECT * FROM (
  SELECT 
      ProductID,
      ProductName,
      Category,
      Price,
      ROW_NUMBER() OVER (PARTITION BY Category ORDER BY Price DESC) AS RowNum
  FROM Products
) AS RankedProducts
WHERE RowNum <= 3;