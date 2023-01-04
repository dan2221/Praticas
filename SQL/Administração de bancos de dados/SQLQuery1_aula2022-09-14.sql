SELECT * FROM [Order Details] AS od INNER JOIN orders AS o
	ON o.OrderID=od.OrderID
	INNER JOIN products AS p
	ON p.ProductID=od.ProductID
	INNER JOIN Categories AS c
	ON c.CategoryID=p.CategoryID
	WHERE orderdate BETWEEN '01/04/2022' AND '30/06/2022'

SELECT CategoryName, SUM(od.unitprice*quantity) AS 'VENDAS 2 TRIM.'
	FROM [Order Details] AS od INNER JOIN orders AS o
		ON o.OrderID=od.OrderID
		INNER JOIN products AS p
		ON p.ProductID=od.ProductID
		INNER JOIN Categories AS c
		ON c.CategoryID=p.CategoryID
		WHERE orderdate BETWEEN '01/04/2022' AND '30/06/2022'
		GROUP BY CategoryName

-- Mostre o valor de vendas pelo país
SELECT country, SUM(unitprice*quantity) AS 'vendas por pais.'
	FROM [Order Details] AS od INNER JOIN orders AS o
	ON o.orderid=od.OrderID INNER JOIN customers AS c
	ON C.cUSTOMERid = o.CustomerID
	GROUP BY Country