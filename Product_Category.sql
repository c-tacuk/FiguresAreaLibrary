SELECT P.Name, C.Name 
FROM Products P
LEFT JOIN ProductsCategories PC
	ON P.Id = PC.ProductId
LEFT JOIN Categories c
	ON PC.CategoryId = C.Id
ORDER BY P.Name;