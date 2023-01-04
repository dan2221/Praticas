/**
	Para rodar esta consulta é necessário se conectar
	com o banco de dados "Banco Northwind 2022 semestre 2"
*/

-- INNER JOIN

-- INTERLIGANDO 2 TABELAS COM 1 CHAVE -------------------------------------

-- Orders e [order details]
SELECT * FROM Orders AS o INNER JOIN[order details] AS od
	ON o.OrderID = od.OrderID

-- Products e Shippers
SELECT * FROM Products AS p INNER JOIN [Order Details] AS od
	ON p.ProductID = od.ProductID

-- Orders e shippers
--SELECT * FROM orders INNER JOIN Shippers
--	ON ShipVia.ShipperID xxxxxxxxxxxxxxxxxxxxxxxxxxxxx

-- Orders e Employers
SELECT * FROM Orders AS J INNER JOIN Employees AS A
	ON J.EmployeeID = A.EmployeeID

-- INTERLIGANDO 3 TABELAS COM 2 CHAVES DIFERENTES (EmployeeID e CustomerID) --

-- Orders, Employers e Costumers
SELECT * FROM Orders AS O INNER JOIN Employees AS E
	ON O.EmployeeID = E.EmployeeID
	INNER JOIN Customers AS C
	ON O.CustomerID = C.CustomerID

-- Products, Categories, Suppliers
SELECT * FROM Suppliers AS o INNER JOIN Products AS p
	ON o.SupplierID = p.SupplierID
	INNER JOIN Categories AS c
	ON p.CategoryID = c.CategoryID

-- suppliers, products, categories, [order details] e orders
SELECT * FROM Suppliers AS s
	INNER JOIN Products AS p
	ON s.SupplierID = p.SupplierID
	INNER JOIN Categories AS c
	ON c.CategoryID = p.CategoryID
	INNER JOIN [Order Details] AS odt
	ON p.ProductID = odt.ProductID
	INNER JOIN Orders AS od
	ON odt.OrderID = od.OrderID
