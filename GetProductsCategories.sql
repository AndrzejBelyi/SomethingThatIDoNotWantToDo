SELECT 
	P.Id AS ProductId,
	P.Name AS ProductName,
	PC.Name AS CategoryName
FROM Product P
	LEFT JOIN 
		(
			SELECT 
				PC.ProductId,
				PC.CategoryId,
				C.Name
			FROM ProductCategory PC
				LEFT JOIN Category C
				ON PC.CategoryId = C.Id
		) AS PC 
	ON P.Id = PC.ProductId 